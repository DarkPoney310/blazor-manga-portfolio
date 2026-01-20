using System.Collections.Generic;
using System.Linq;
using PortFolio.Models;

namespace PortFolio.Services;

public static class BookRepository
{
    // Simulation d'une base de données en mémoire
    private static readonly List<BookData> _books = new()
    {
        // --- TOME 01 : E-Collecte ---
        new BookData
        {
            Slug = "tome-01",
            Title = "Charm",
            Subtitle = "Refonte UX Data",
            ShelfMeta = ".NET • Blazor • EF",
            AccentColor = "#0B0B0C",
            StampLabel = "TOME 01",
            WidthPx = 78, HeightPx = 252,
            
            Role = "Lead Développeur",
            Context = "Startup / Freelance",
            Year = "2024",
            Duration = "3 mois",
            Sfx = "DOKOON",
            
            DescriptionTitle = "Application Métier",
            NarrationHtml = @"
                <p>Mission complexe visant à refondre l'expérience utilisateur pour la collecte de données terrain.</p>
                <p>Le défi principal : assurer la fluidité sur des tablettes peu puissantes tout en gérant une synchronisation lourde en arrière-plan (Offline-first).</p>",
            
            Stack = new List<StackItem>
            {
                new("C# / .NET 8", "/assets/csharp-original.svg", "Logique métier + API"),
                new("Blazor WASM", "/assets/blazor-original.svg", "UI interactive (SPA)"),
                new("PostgreSQL", "/assets/postgresql-original.svg", "Stockage relationnel"),
                new("Docker", "/assets/docker-original.svg", "Conteneurisation")
            },

            Contributions = new List<string>
            {
                "Conception de l’architecture (services, accès données, API).",
                "Mise en place d’un mode offline-first (cache, reprise, conflits).",
                "Optimisation performance (UI, chargements, latence perçue).",
                "Industrialisation (Docker, environnements, CI/CD) et documentation."
            },
            
            DemoLink = "https://style-charm.com/",
        },

        // --- TOME 02 : Mobile App ---
        new BookData
        {
            Slug = "tome-02",
            Title = "GoManga",
            Subtitle = "Lecteur Mobile",
            ShelfMeta = "Flutter • Firebase",
            AccentColor = "#2B2E5E",
            StampLabel = "TOME 02",
            WidthPx = 66, HeightPx = 238,
            
            Role = "Développeur Fullstack",
            Context = "Projet Perso",
            Year = "2023",
            Duration = "2 mois",
            Sfx = "SWISH",
            
            DescriptionTitle = "App Mobile Cross-platform",
            NarrationHtml = @"
                <p>Création d'un lecteur de manga optimisé pour le mobile avec Flutter.</p>
                <p>L'objectif était de maîtriser le cycle de vie des widgets Flutter et la gestion d'état avec Riverpod. Intégration de Firebase pour les favoris utilisateur.</p>",
            
            Stack = new List<StackItem>
            {
                new("Flutter", "/assets/flutter-original.svg", "Framework UI Mobile"),
                new("Dart", "/assets/dart-original.svg", "Langage principal"),
                new("Firebase", "/assets/google-original.svg", "Auth & Database"), // Note: icone google par defaut si firebase manque
            },
            Contributions = new List<string>
            {
                "Conception UI mobile (navigation, écrans, composants réutilisables).",
                "Gestion d’état et cycle de vie (Riverpod / patterns Flutter).",
                "Auth + persistance (Firebase) et optimisation des temps de chargement."
            },
             DemoLink = "#",
             SourceCodeLink = "https://github.com/darkponey"
        },

        // --- TOME 03 : API Auth ---
        new BookData
        {
            Slug = "tome-03",
            Title = "Identity",
            Subtitle = "Microservice Auth",
            ShelfMeta = "ASP.NET • OAuth2",
            AccentColor = "#1D4D3A",
            StampLabel = "TOME 03",
            WidthPx = 70, HeightPx = 244,
            
            Role = "Backend Dev",
            Context = "Entreprise",
            Year = "2023",
            Duration = "En cours",
            Sfx = "BEEP",
            
            DescriptionTitle = "Sécurité & IAM",
            NarrationHtml = @"
                <p>Implémentation d'un serveur d'identité centralisé basé sur Duende IdentityServer.</p>
                <p>Gestion des tokens JWT, refresh tokens et permissions granulaires pour une architecture microservices.</p>",
            
            Stack = new List<StackItem>
            {
                new("C#", "/assets/csharp-original.svg", "Backend"),
                new("SQL Server", "/assets/microsoftsqlserver-original.svg", "Base de données"),
                new("Docker", "/assets/docker-original.svg", "Déploiement")
            },
            Contributions = new List<string>
            {
                "Implémentation des flows OAuth2/OIDC (JWT, refresh tokens).",
                "Modélisation des permissions et intégration microservices.",
                "Hardening sécurité (policies, rotation secrets, monitoring)."
            }
        },

        // --- DEMO 1 : Ink UI ---
        new BookData
        {
            Slug = "ink-ui",
            Title = "Ink UI",
            Subtitle = "Design System",
            ShelfMeta = "CSS • Animations",
            AccentColor = "#4A2A18",
            StampLabel = "DEMO",
            WidthPx = 62, HeightPx = 232,
            
            Role = "Designer / Dev",
            Context = "Portfolio",
            Year = "2025",
            Duration = "Permanent",
            Sfx = "POOF",
            
            DescriptionTitle = "Expérimentation Visuelle",
            NarrationHtml = @"
                <p>Ce portfolio est lui-même une démo technique.</p>
                <p>Utilisation intensive de CSS Grid, Transformations 3D et masques pour créer un rendu papier/encre sans utiliser de Canvas ou WebGL lourd.</p>",
            
            Stack = new List<StackItem>
            {
                new("CSS3", "/assets/css3-original.svg", "Styling avancé"),
                new("Tailwind", "/assets/tailwindcss-original.svg", "Utility classes"),
                new("Blazor", "/assets/blazor-original.svg", "Composants")
            },
            Contributions = new List<string>
            {
                "Design system (tokens, composants, états) en pur CSS.",
                "Animations/perf (GPU, transforms, content-visibility).",
                "Intégration Blazor (composants, navigation, interactions JS)."
            },
            SourceCodeLink = "https://github.com/darkponey"
        }
    };

    public static List<BookData> GetAll() => _books;

    public static BookData? GetBySlug(string slug) 
    {
        return _books.FirstOrDefault(b => b.Slug.Equals(slug, System.StringComparison.OrdinalIgnoreCase));
    }
}
