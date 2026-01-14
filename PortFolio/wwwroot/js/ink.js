// wwwroot/js/ink.js

// 1) Reveal on scroll (one-time)
export function observeReveals() {
    const els = document.querySelectorAll(".reveal");
    if (!els.length) return;

    const io = new IntersectionObserver((entries) => {
        for (const e of entries) {
            if (e.isIntersecting) {
                e.target.classList.add("is-in");
                io.unobserve(e.target);
            }
        }
    }, { threshold: 0.12 });

    els.forEach(el => io.observe(el));
}

// 2) Ink wipe transition - returns duration in ms
export function playInkWipe() {
    const el = document.getElementById("inkWipe");
    if (!el) return 0;

    document.body.classList.add("no-scroll");
    el.classList.add("is-active");

    const duration = 560;

    window.setTimeout(() => {
        el.classList.remove("is-active");
        document.body.classList.remove("no-scroll");
    }, duration);

    return duration;
}
