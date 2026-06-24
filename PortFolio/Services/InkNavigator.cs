using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace PortFolio.Services;

/// <summary>
/// Plays the ink-wipe page transition for plain left-clicks on <c>[data-inklink]</c>
/// anchors, then performs SPA navigation in .NET. The JS click interceptor only calls
/// back here for unmodified clicks, so Ctrl/Cmd/Shift/middle-clicks keep their native
/// "open in new tab" behaviour. Registered once with the JS module by <c>MainLayout</c>.
/// </summary>
public sealed class InkNavigator
{
    private readonly NavigationManager _nav;
    private readonly IJSRuntime _js;
    private IJSObjectReference? _ink;

    public InkNavigator(NavigationManager nav, IJSRuntime js)
    {
        _nav = nav;
        _js = js;
    }

    [JSInvokable]
    public async Task NavigateFromInk(string href)
    {
        if (string.IsNullOrWhiteSpace(href)) return;

        _ink ??= await _js.InvokeAsync<IJSObjectReference>("import", "./js/ink.js");
        var ms = await _ink.InvokeAsync<int>("playInkWipe");

        // In-page anchor (e.g. "#contact").
        if (href.StartsWith('#'))
        {
            if (ms > 0) await Task.Delay(Math.Min(ms / 3, 220));
            _nav.NavigateTo(href);
            await _ink.InvokeVoidAsync("scrollToId", href.TrimStart('#'));
            return;
        }

        // Path with a fragment (e.g. "/#library").
        var hash = href.IndexOf('#');
        if (hash > 0)
        {
            if (ms > 0) await Task.Delay(ms);
            _nav.NavigateTo(href[..hash]);
            await Task.Delay(120); // let the target page render before scrolling
            await _ink.InvokeVoidAsync("scrollToId", href[(hash + 1)..]);
            return;
        }

        // Plain route change.
        if (ms > 0) await Task.Delay(ms);
        _nav.NavigateTo(href);
    }
}
