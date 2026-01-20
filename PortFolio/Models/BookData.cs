using System.Collections.Generic;

namespace PortFolio.Models;

public record StackItem(string Name, string IconSrc, string UsedFor);

public class BookData
{
    // Infos pour l'étagère (LibraryShelf)
    public string Slug { get; set; } = ""; // ID unique (ex: "tome-01")
    public string Title { get; set; } = ""; // Titre (ex: "E-Collecte")
    public string Subtitle { get; set; } = ""; // Sous-titre étagère
    public string ShelfMeta { get; set; } = ""; // ex: ".NET • Blazor"
    public string AccentColor { get; set; } = "#0B0B0C";
    public string StampLabel { get; set; } = "TOME"; // ex: "TOME 01"

    // Dimensions visuelles pour l'étagère
    public int WidthPx { get; set; } = 72;
    public int HeightPx { get; set; } = 240;

    // Infos pour le détail (LibraryBook)
    public string Role { get; set; } = "Développeur";
    public string Context { get; set; } = "Freelance";
    public string Year { get; set; } = "2024";
    public string Duration { get; set; } = "N/A";

    // Contenu riche
    public string DescriptionTitle { get; set; } = "Détail de mission";
    public string NarrationHtml { get; set; } = "<p>Description à venir...</p>";

    public string Sfx { get; set; } = "KRAK"; // Le bruitage Manga

    //Live2d
    public string? Live2d { get; set; }

// Liens
    public string? DemoLink { get; set; }
    public string? SourceCodeLink { get; set; }

    // Liste technique
    public List<StackItem> Stack { get; set; } = new();

    // Contenu pro (page détail)
    public List<string> Contributions { get; set; } = new();
}
