using PortFolio.Models;

namespace PortFolio.Services;

public static class BookRepository
{
    public const string GitHubRepoUrl = "https://github.com/DarkPoney310/blazor-manga-portfolio";

    // Bibliothèque en mémoire — chaque "tome" est un projet ou une démo.
    private static readonly List<BookData> _books = new()
    {
        // ============================================
        // MELOTOGO — plateforme streaming (MVP en prod)
        // ============================================
        new BookData
        {
            Slug = "melotogo",
            Title = "MeloTogo",
            Subtitle = "Plateforme de streaming musical",
            ShelfMeta = ".NET 8 • PostgreSQL • Auto-hébergé",
            AccentColor = "#4C2A85",
            Category = "projet",
            StampLabel = "MVP EN PROD",
            WidthPx = 78,
            HeightPx = 252,

            Role = "Développeur full-stack (solo)",
            Context = "Projet personnel",
            Year = "2026",
            Duration = "En cours",

            DescriptionTitle = "Streaming musical auto-hébergé pour artistes togolais",
            NarrationHtml = """
                <p class="drop-cap"><strong>Contexte :</strong> offrir aux artistes togolais une plateforme de diffusion musicale moderne, conçue et déployée de bout en bout en solo jusqu'à la mise en production (MVP).</p>

                <p><strong>Le cœur technique :</strong></p>
                <ul>
                    <li>Backend ASP.NET Core 8 (PostgreSQL), temps réel via SignalR, stockage objet S3 (MinIO / Cloudflare R2)</li>
                    <li>Worker FFmpeg de transcodage <strong>auto-hébergé</strong>, développé pour ne dépendre d'aucun service externe</li>
                    <li>Recherche musicale par <strong>similarité audio</strong> : embeddings CLAP-HTSAT exécutés via ONNX Runtime et indexés dans pgvector</li>
                </ul>

                <p><strong>Déploiement & exploitation en autonomie :</strong> VM Debian (Google Cloud), conteneurs Docker, CI/CD GitHub Actions, reverse proxy Caddy, DNS Cloudflare, frontend Next.js (BFF). Qualité assurée par tests unitaires et E2E (Playwright), health checks, journaux d'audit et domain events, supervision via .NET Aspire et Portainer.</p>
                """,

            DemoLink = "https://melotogo.com",
            SourceCodeLink = null,

            Stack = new()
            {
                new StackItem("ASP.NET Core 8", "/assets/dotnetcore-original.svg", "Backend & API"),
                new StackItem("C#", "/assets/csharp-original.svg", "Langage principal"),
                new StackItem("PostgreSQL", "/assets/postgresql-original.svg", "Données + pgvector"),
                new StackItem("Redis", "/assets/redis-original.svg", "Cache & files"),
                new StackItem("Docker", "/assets/docker-original.svg", "Conteneurisation & déploiement"),
                new StackItem("Google Cloud", "/assets/googlecloud-original.svg", "VM Debian / hébergement"),
                new StackItem("Next.js", "/assets/nextjs-original.svg", "Frontend (BFF)"),
            },

            Contributions = new()
            {
                "Architecture et développement full-stack en solo, de l'API à la mise en production",
                "Worker FFmpeg de transcodage auto-hébergé (zéro dépendance externe)",
                "Recherche par similarité audio : CLAP-HTSAT + ONNX Runtime + pgvector",
                "Temps réel via SignalR, stockage objet S3 (MinIO / Cloudflare R2)",
                "CI/CD GitHub Actions, Docker, Caddy, Cloudflare sur VM Debian (GCP)",
                "Tests unitaires & E2E (Playwright), health checks, domain events"
            },

            KeyMetrics = new() { "MVP en production", "Transcodage FFmpeg auto-hébergé", "Recherche par similarité (pgvector)" }
        },

        // ============================================
        // ÉQUI-ASSIETTE — 1er prix DigiEduHack 2025
        // ============================================
        new BookData
        {
            Slug = "equi-assiette",
            Title = "Équi-Assiette",
            Subtitle = "Application éducative de composition nutritionnelle",
            ShelfMeta = "Next.js • Gemini AI • 1er prix",
            AccentColor = "#C0392B",
            Category = "projet",
            StampLabel = "1ER PRIX",
            WidthPx = 76,
            HeightPx = 248,

            Role = "Développeur full-stack (solo)",
            Context = "DigiEduHack 2025",
            Year = "2025",
            Duration = "Hackathon",

            DescriptionTitle = "« The Plate Architect » — coach nutritionnel éducatif et interactif",
            NarrationHtml = """
                <p class="drop-cap"><strong>Contexte :</strong> l'analphabétisme nutritionnel alimente la montée des maladies chroniques (obésité, diabète de type 2, hypertension). Défi « Digital Education for Health & Well-being » du DigiEduHack 2025.</p>

                <p><strong>Solution :</strong> Équi-Assiette — « The Plate Architect » — transforme la composition d'un repas en jeu éducatif. Développé en solo, lauréat du 1er prix.</p>

                <p><strong>Le cœur du produit :</strong></p>
                <ul>
                    <li><strong>Moteur de cohérence alimentaire</strong> (« Food Coherence Engine ») : des règles inspirées du Guide alimentaire canadien détectent les combinaisons déséquilibrées et guident vers des repas cohérents — bien plus qu'un compteur de calories</li>
                    <li><strong>Coach IA (Gemini)</strong> : à partir du plat déjà composé par l'utilisateur, génère des repas complémentaires pour équilibrer l'ensemble de sa journée</li>
                    <li><strong>Données &amp; sécurité (Open Food Facts)</strong> : recherche de produits, score NOVA et alertes en temps réel sur les produits rappelés</li>
                    <li><strong>Gamification</strong> : assiette virtuelle en glisser-déposer, jauges d'équilibre, mascotte et feedback instantané (Framer Motion)</li>
                </ul>
                """,

            DemoLink = "https://equi-assiette.vercel.app",
            SourceCodeLink = null,

            Stack = new()
            {
                new StackItem("Next.js 14", "/assets/nextjs-original.svg", "Framework full-stack"),
                new StackItem("TypeScript", "/assets/typescript-original.svg", "Langage"),
                new StackItem("React", "/assets/react-original.svg", "Bibliothèque UI"),
                new StackItem("Prisma", "/assets/prisma-original.svg", "ORM"),
            },

            Contributions = new()
            {
                "Conception et développement full-stack en solo",
                "Moteur de cohérence alimentaire (règles du Guide alimentaire canadien)",
                "Intégration du coach IA Gemini (repas complémentaires sur la journée)",
                "Intégration Open Food Facts : score NOVA + alertes produits rappelés",
                "Gamification : assiette en glisser-déposer, jauges, feedback (Framer Motion)",
                "Design responsive web & mobile"
            },

            KeyMetrics = new() { "1er prix DigiEduHack 2025", "Coach IA (Gemini)", "En ligne sur Vercel" }
        },

        // ============================================
        // CHARM — application en production (stores)
        // ============================================
        new BookData
        {
            Slug = "charm-salon",
            Title = "CHARM",
            Subtitle = "Gestion de salons de coiffure",
            ShelfMeta = "Laravel • Flutter • Production",
            AccentColor = "#D4455E",
            Category = "projet",
            StampLabel = "PRODUCTION",
            WidthPx = 72,
            HeightPx = 240,

            Role = "Développeur backend & architecture API",
            Context = "BH Consulting (freelance)",
            Year = "2025",
            Duration = "6 mois",

            DescriptionTitle = "Application commerciale en production",
            NarrationHtml = @"
                <p class=""drop-cap""><strong>Contexte :</strong> les gérants de salons de coiffure au Togo manquaient d'outils modernes de gestion digitalisée.</p>

                <p><strong>Mission :</strong> concevoir et développer CHARM, une application mobile complète de gestion de salons, et la mener jusqu'à la publication sur les stores.</p>

                <p><strong>Réalisations principales :</strong></p>
                <ul>
                    <li>Responsable de l'architecture de l'API REST en PHP Laravel</li>
                    <li>Architecture DDD + CQRS + SOLID + DRY appliquée</li>
                    <li>Domaine métier modélisé : clients, rendez-vous, services, paiements, commissions</li>
                    <li>Authentification et autorisation sécurisées</li>
                    <li>Gestion des transactions critiques (paiements)</li>
                    <li>Publication sur Google Play Store et Apple App Store</li>
                </ul>

                <p><strong>Impact :</strong> application disponible sur les deux stores et utilisée par plusieurs salons au Togo.</p>
            ",

            DemoLink = "https://style-charm.com/",
            SourceCodeLink = null, // Code propriétaire (client)

            Stack = new()
            {
                new StackItem("PHP", "/assets/php-original.svg", "Langage backend"),
                new StackItem("Laravel", "/assets/laravel-original.svg", "Framework"),
                new StackItem("MySQL", "/assets/mysql-original.svg", "Base de données"),
                new StackItem("Flutter", "/assets/flutter-original.svg", "Frontend mobile"),
            },

            Contributions = new()
            {
                "Architecture backend API REST en PHP Laravel",
                "Architecture DDD + CQRS + SOLID",
                "Modélisation du domaine salon de coiffure",
                "Gestion des transactions et paiements",
                "Publication Play Store + App Store",
                "Support production et optimisations",
                "Contribution à la logique frontend Flutter"
            },

            KeyMetrics = new() { "App Store & Play Store", "En production", "Architecture DDD" }
        },

        // ============================================
        // RECYCLE — application en cours
        // ============================================
        new BookData
        {
            Slug = "recycle-app",
            Title = "RECYCLE",
            Subtitle = "Sensibilisation et collecte collaborative",
            ShelfMeta = "Laravel • Flutter • Gamification",
            AccentColor = "#22A35A",
            Category = "projet",
            StampLabel = "EN COURS",
            WidthPx = 72,
            HeightPx = 240,

            Role = "Développeur backend & architecture API",
            Context = "BH Consulting (freelance)",
            Year = "2025",
            Duration = "En cours",

            DescriptionTitle = "Impact environnemental & engagement utilisateur",
            NarrationHtml = @"
                <p class=""drop-cap""><strong>Contexte :</strong> sensibiliser au recyclage et structurer un réseau de collecte collaborative au Togo.</p>

                <p><strong>Mission :</strong> concevoir et développer RECYCLE, une application de sensibilisation avec collecte collaborative et gamification.</p>

                <p><strong>Réalisations principales :</strong></p>
                <ul>
                    <li>Responsable de l'architecture de l'API REST en PHP Laravel</li>
                    <li>Architecture DDD + CQRS + SOLID + DRY</li>
                    <li>Domaine métier : utilisateurs, points de collecte, types de déchets</li>
                    <li>Système de gamification : badges, classements, score</li>
                    <li>Intégration de la géolocalisation des points de collecte</li>
                </ul>
            ",

            DemoLink = null,
            SourceCodeLink = null,

            Stack = new()
            {
                new StackItem("PHP", "/assets/php-original.svg", "Langage backend"),
                new StackItem("Laravel", "/assets/laravel-original.svg", "Framework"),
                new StackItem("MySQL", "/assets/mysql-original.svg", "Base de données"),
                new StackItem("Flutter", "/assets/flutter-original.svg", "Frontend mobile"),
            },

            Contributions = new()
            {
                "Architecture backend API REST en PHP Laravel",
                "Architecture DDD + CQRS + SOLID",
                "Système de gamification complet",
                "Intégration de la géolocalisation",
                "Logique de collecte collaborative",
                "Modélisation du domaine du recyclage"
            },

            KeyMetrics = new() { "Laravel + Flutter", "Gamification", "Géolocalisation" }
        },

        // ============================================
        // E-COLLECTE — deux stages fusionnés (2023–2024)
        // ============================================
        new BookData
        {
            Slug = "e-collecte",
            Title = "E-Collecte",
            Subtitle = "Système de collecte fiscale municipale",
            ShelfMeta = ".NET • Blazor • DDD • CQRS",
            AccentColor = "#0B5345",
            Category = "projet",
            StampLabel = "2 STAGES",
            WidthPx = 72,
            HeightPx = 240,

            Role = "Développeur backend .NET",
            Context = "Evenou-Group, puis SIC — Lomé",
            Year = "2023 – 2024",
            Duration = "10 mois (2 stages)",

            DescriptionTitle = "Digitalisation de la collecte fiscale municipale",
            NarrationHtml = @"
                <p class=""drop-cap""><strong>Contexte :</strong> les mairies du Togo géraient les taxes à 100 % sur papier. Aucune digitalisation.</p>

                <p><strong>Phase 1 — conception (Evenou-Group, 2023) :</strong> concevoir et développer une API REST en ASP.NET Core pour digitaliser le processus de collecte des taxes municipales.</p>
                <ul>
                    <li>Architecture DDD + CQRS + MediatR + FluentValidation</li>
                    <li>Modélisation du domaine complexe de la fiscalité municipale</li>
                    <li>Séparation lecture/écriture via CQRS</li>
                    <li>Interface de gestion en Blazor</li>
                    <li>Base de données SQL Server (intégrité fiscale)</li>
                    <li>Pilotage SCRUM, cahiers des charges, GitLab / Microsoft Project</li>
                </ul>

                <p><strong>Phase 2 — production (SIC, 2024) :</strong> refactoriser, optimiser et durcir le système pour un environnement de production critique.</p>
                <ul>
                    <li>Refactorisation de l'architecture DDD + CQRS</li>
                    <li>Optimisation des performances sur de gros volumes</li>
                    <li>Renforcement de la stabilité et de la sécurité des transactions</li>
                    <li>Tests d'intégrité des données fiscales</li>
                </ul>

                <p><strong>Apprentissage clé :</strong> mon premier projet où DDD + CQRS ont été appliqués de bout en bout, puis confrontés aux contraintes réelles de la production.</p>
            ",

            DemoLink = null,
            SourceCodeLink = null,

            Stack = new()
            {
                new StackItem("C#", "/assets/csharp-original.svg", "Langage principal"),
                new StackItem("ASP.NET Core", "/assets/dotnetcore-original.svg", "Framework backend"),
                new StackItem("Blazor", "/assets/blazor-original.svg", "Interface web"),
                new StackItem("EF Core", "/assets/entityframeworkcore-original.svg", "ORM"),
                new StackItem("SQL Server", "/assets/microsoftsqlserver-original.svg", "Base de données"),
                new StackItem("GitLab", "/assets/gitlab-original.svg", "Versioning"),
            },

            Contributions = new()
            {
                "Architecture DDD + CQRS + MediatR",
                "API REST scalable et maintenable",
                "Interface Blazor de gestion municipale",
                "Modélisation du domaine fiscal",
                "Refactorisation et optimisation pour la production",
                "Renforcement de la sécurité des transactions",
                "Gestion de projet SCRUM/Agile"
            },

            KeyMetrics = new() { "ASP.NET Core", "DDD + CQRS", "Conception → production" }
        },

        // ============================================
        // ELAUD-COIFFURE — projet personnel déployé
        // ============================================
        new BookData
        {
            Slug = "elaud-coiffure",
            Title = "Elaud-Coiffure",
            Subtitle = "Plateforme de gestion et réservation de salon",
            ShelfMeta = "Next.js • Prisma • PostgreSQL",
            AccentColor = "#8B4513",
            Category = "projet",
            StampLabel = "PROJET",
            WidthPx = 72,
            HeightPx = 240,

            Role = "Développeur full-stack & architecte",
            Context = "Projet personnel",
            Year = "2025",
            Duration = "3 mois",

            DescriptionTitle = "Plateforme de gestion et de réservation pour salons de coiffure",
            NarrationHtml = """
                <p class="drop-cap"><strong>Contexte :</strong> offrir aux salons une solution moderne et intégrée pour gérer les réservations en ligne.</p>

                <p><strong>Solution :</strong> Elaud-Coiffure, une plateforme full-stack côté client (réservation en ligne) et côté admin (gestion du salon), avec hébergement performant des photos sur Cloudinary.</p>

                <p><strong>Fonctionnalités :</strong></p>
                <ul>
                    <li>Réservation par créneau horaire</li>
                    <li>Emails de confirmation automatiques (cron jobs)</li>
                    <li>Dashboard admin avec gestion du catalogue</li>
                    <li>Galerie de photos hébergée sur Cloudinary</li>
                </ul>
                """,

            DemoLink = "https://elaud-coiffure.vercel.app",
            SourceCodeLink = null,

            Stack = new()
            {
                new StackItem("Next.js 14", "/assets/nextjs-original.svg", "Framework full-stack"),
                new StackItem("TypeScript", "/assets/typescript-original.svg", "Langage"),
                new StackItem("PostgreSQL", "/assets/postgresql-original.svg", "Base de données"),
                new StackItem("Prisma", "/assets/prisma-original.svg", "ORM"),
                new StackItem("Cloudinary", "/assets/cloudinary-original.svg", "Hébergement médias"),
                new StackItem("Vercel", "/assets/vercel-original.svg", "Déploiement"),
            },

            Contributions = new()
            {
                "Architecture et développement full-stack",
                "Système de réservation par créneaux",
                "Intégration Cloudinary pour les photos",
                "Dashboard admin de gestion du catalogue",
                "Automatisation des rappels par email (cron)",
                "Déploiement et optimisation sur Vercel"
            },

            KeyMetrics = new() { "Next.js + Prisma", "PostgreSQL + Cloudinary", "En ligne sur Vercel" }
        },

        // ============================================
        // INK UI — ce portfolio (démo technique)
        // ============================================
        new BookData
        {
            Slug = "ink-ui",
            Title = "Ink UI",
            Subtitle = "Ce portfolio",
            ShelfMeta = "Blazor WASM • Tailwind • Brotli",
            AccentColor = "#4A2A18",
            Category = "demo",
            StampLabel = "CE SITE",
            WidthPx = 62,
            HeightPx = 232,

            Role = "Développeur Backend / Full-stack",
            Context = "Projet personnel",
            Year = "2025",
            Duration = "Continu",

            DescriptionTitle = "Une démo technique : Blazor WebAssembly taillé pour la vitesse",
            NarrationHtml = @"
                <p class=""drop-cap"">Le site que vous lisez. Une interface immersive façon « manga / encre » construite en Blazor WebAssembly et CSS moderne (Grid, transforms 3D), sans aucune librairie de composants.</p>
                <p>Le vrai défi était la performance : un Blazor WASM par défaut télécharge plusieurs mégaoctets avant de s'afficher. En retirant les dépendances superflues, en activant la globalisation invariante et en servant les fichiers précompressés en Brotli, le poids au premier rendu est passé d'environ 8 Mo à près de 2 Mo.</p>",

            DemoLink = null,
            SourceCodeLink = GitHubRepoUrl,

            Stack = new()
            {
                new StackItem("Blazor WASM", "/assets/blazor-original.svg", "Composants interactifs"),
                new StackItem("Tailwind CSS", "/assets/tailwindcss-original.svg", "Styling utility-first"),
                new StackItem("C#", "/assets/csharp-original.svg", "Logique frontend"),
            },

            Contributions = new()
            {
                "Architecture en composants Blazor réutilisables",
                "Design system « Ink » sur-mesure (CSS Grid, transforms 3D)",
                "Payload réduit d'environ 8 Mo à ~2 Mo au premier rendu",
                "Zéro librairie de composants : HTML/CSS natif",
                "Pré-compression Brotli servie via IIS"
            },

            KeyMetrics = new() { "Blazor WASM", "~2 Mo au 1er rendu", "0 lib de composants" }
        }
    };

    public static IReadOnlyList<BookData> GetAll() => _books;

    public static IReadOnlyList<BookData> GetByCategory(string category) =>
        _books.Where(b => b.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();

    public static BookData? GetBySlug(string slug) =>
        _books.FirstOrDefault(b => b.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));

    // Navigation suivant/précédent au sein de la même catégorie (évite de sauter
    // d'un "projet" vers une "démo").
    public static BookData? GetNext(string slug)
    {
        var current = GetBySlug(slug);
        if (current is null) return null;

        var siblings = _books.Where(b => b.Category == current.Category).ToList();
        var index = siblings.FindIndex(b => b.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));
        if (index == -1 || index == siblings.Count - 1) return null;
        return siblings[index + 1];
    }

    public static BookData? GetPrevious(string slug)
    {
        var current = GetBySlug(slug);
        if (current is null) return null;

        var siblings = _books.Where(b => b.Category == current.Category).ToList();
        var index = siblings.FindIndex(b => b.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));
        if (index <= 0) return null;
        return siblings[index - 1];
    }
}
