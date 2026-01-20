using System.Collections.Generic;
using System.Linq;
using PortFolio.Models;

namespace PortFolio.Services;

public static class BookRepository
{
    // Simulation d'une base de données en mémoire
    private static readonly List<BookData> _books = new()
    {
        new BookData
        {
            Slug = "e-collecte-evenou",
            Title = "E-Collecte",
            Subtitle = "Système de collecte fiscale municipale",
            ShelfMeta = ".NET Core • Blazor • DDD • CQRS",
            AccentColor = "#0B5345",
            StampLabel = "STAGE 01",
            WidthPx = 72,
            HeightPx = 240,

            // Détail
            Role = "Programmeur-Analyste",
            Context = "Evenou-Group, Lomé",
            Year = "2023",
            Duration = "6 mois",

            // Description riche
            DescriptionTitle = "Digitalisation de la collecte fiscale municipale",
            NarrationHtml = @"
                <p class=""drop-cap""><strong>Contexte :</strong> Les mairies du Togo géraient les taxes 100% sur papier. Absence totale de digitalisation.</p>
            
                <p><strong>Mission :</strong> Concevoir et développer une API REST en ASP.NET Core pour digitaliser complètement le processus de collecte des taxes municipales.</p>
            
                <p><strong>Réalisations principales :</strong></p>
                <ul>
                    <li>Architecte d'une solution scalable utilisant DDD + CQRS + MediatR + FluentValidation</li>
                    <li>Modélisation du domaine métier complexe de la fiscalité municipale avec DDD</li>
                    <li>Séparation lecture/écriture via CQRS pour performances optimales</li>
                    <li>Orchestration des commandes avec MediatR pour maintenabilité</li>
                    <li>Développement frontend Blazor pour interface de gestion municipale</li>
                    <li>Gestion complète de la base de données (SQL Server) pour intégrité fiscale</li>
                </ul>

                <p><strong>Gestion de projet :</strong></p>
                <ul>
                    <li>Pilotage en SCRUM/Agile (sprints 2 semaines)</li>
                    <li>Rédaction complète des cahiers des charges techniques et fonctionnels</li>
                    <li>Communication directe avec porteurs de projet municipaux</li>
                    <li>Outils : Microsoft Project, GitLab</li>
                </ul>

                <p><strong>Impact :</strong> Système capable de traiter les déclarations de milliers de citoyens avec scalabilité et maintenabilité garanties. Premier projet où DDD + CQRS ont été vraiment appliqués en production.</p>
            ",

            Sfx = "KRAK",
            Live2d = "/live2d/haruto/haruto.model.json", // Pas de Live2D pour ce projet
            DemoLink = null,
            SourceCodeLink = null,

            // Stack technique
            Stack = new()
            {
                new StackItem("C#", "/assets/csharp-original.svg", "Langage principal"),
                new StackItem("ASP.NET Core", "/assets/dotnetcore-original.svg", "Framework backend"),
                new StackItem("Blazor", "/assets/blazor-original.svg", "Interface web"),
                new StackItem("Entity Framework Core", "/assets/entityframeworkcore-original.svg", "ORM"),
                new StackItem("SQL Server", "/assets/microsoftsqlserver-original.svg", "Base de données"),
                new StackItem("GitLab", "/assets/gitlab-original.svg", "Versioning"),
            },

            Contributions = new()
            {
                "Architecture d'entreprise (DDD + CQRS + MediatR)",
                "API REST scalable et maintenable",
                "Interface Blazor pour gestion municipale",
                "Gestion de projet SCRUM/Agile",
                "Recueil des besoins clients et cahiers des charges",
                "Modélisation complexe du domaine fiscal",
                "Implémentation SOLID et DRY"
            },
            
            KeyMetrics = new()
            {
                "1000+ Citoyens gérés",
                "0% Perte de données",
                "Sprints de 2 semaines"
            }
        },

        // ============================================
        // 2. SIC: E-COLLECTE ITERATION (Optimization)
        // ============================================
        new BookData
        {
            Slug = "e-collecte-sic",
            Title = "E-Collecte v2",
            Subtitle = "Optimisation et passage en production",
            ShelfMeta = ".NET Core • DDD • CQRS • Production",
            AccentColor = "#1B3A56",
            StampLabel = "STAGE 02",
            WidthPx = 72,
            HeightPx = 240,

            Role = "Technicien en Développement",
            Context = "SIC, Lomé",
            Year = "2024",
            Duration = "4 mois",

            DescriptionTitle = "Optimisation du système fiscal pour production",
            NarrationHtml = @"
                <p class=""drop-cap""><strong>Contexte :</strong> Suite à la première phase chez Evenou-Group, le système devait être optimisé et durci pour la production.</p>
            
                <p><strong>Mission :</strong> Refactoriser, optimiser et stabiliser le système de collecte fiscale pour un environnement production critique.</p>
            
                <p><strong>Réalisations principales :</strong></p>
                <ul>
                    <li>Refactorisation complète de l'architecture DDD + CQRS + MediatR</li>
                    <li>Optimisation des performances pour traiter des volumes élevés</li>
                    <li>Amélioration de la stabilité et de la fiabilité du système</li>
                    <li>Tests rigoureux pour intégrité des données fiscales</li>
                    <li>Hardening de la sécurité pour transactions critiques</li>
                </ul>

                <p><strong>Apprentissages :</strong> Expérience réelle des défis de passage en production et cycles d'itération d'optimisation.</p>
            ",

            Sfx = "KRAK",
            Live2d = "/live2d/haruto/haruto.model.json",
            DemoLink = null,
            SourceCodeLink = null,

            Stack = new()
            {
                new StackItem("C#", "/assets/csharp-original.svg", "Langage"),
                new StackItem("ASP.NET Core", "/assets/dotnetcore-original.svg", "Framework"),
                new StackItem("Entity Framework Core", "/assets/entityframeworkcore-original.svg", "ORM"),
                new StackItem("SQL Server", "/assets/microsoftsqlserver-original.svg", "Base"),
                new StackItem("GitHub", "/assets/github-original.svg", "Versioning"),
            },

            Contributions = new()
            {
                "Refactorisation architecture DDD + CQRS",
                "Optimisation des performances en production",
                "Stabilisation et hardening du système",
                "Communication client et feedback loops",
                "Tests et validation d'intégrité fiscale",
                "Amélioration continue en cycles agiles"
            },
            
            KeyMetrics = new()
            {
                "Latence < 200ms",
                "Sécurité renforcée",
                "Architecture Clean"
            }
        },

        // ============================================
        // 3. YAS-TOGO: NEXTJS EXPLORATION
        // ============================================
        new BookData
        {
            Slug = "nextjs-exploration",
            Title = "NextJS Exploration",
            Subtitle = "Découverte du framework moderne full-stack",
            ShelfMeta = "NextJS • React • TypeScript • Full-Stack",
            AccentColor = "#000000",
            StampLabel = "STAGE 03",
            WidthPx = 72,
            HeightPx = 240,

            Role = "Développeur Web",
            Context = "YAS-Togo, Lomé",
            Year = "2024",
            Duration = "2 mois",

            DescriptionTitle = "Transition vers l'écosystème React moderne",
            NarrationHtml = @"
                <p class=""drop-cap""><strong>Contexte :</strong> Après 6+ mois en backend pur (.NET), exploration d'une approche full-stack moderne avec React/Node.js.</p>
            
                <p><strong>Mission :</strong> Apprendre et maîtriser NextJS 14 pour le développement d'applications web modernes.</p>
            
                <p><strong>Apprentissages :</strong></p>
                <ul>
                    <li>NextJS 14 : routing, API routes, Server Components</li>
                    <li>React patterns modernes et hooks</li>
                    <li>TypeScript pour type-safety en frontend</li>
                    <li>Transition d'une architecture backend-first à full-stack intégrée</li>
                    <li>Différences philosophiques entre .NET et Node.js ecosystem</li>
                </ul>

                <p><strong>Impact :</strong> Élargissement de la palette technologique et compréhension des approches alternatives d'architecture web.</p>
            ",

            Sfx = "KRAK",
            Live2d = null,
            DemoLink = "/live2d/bilibili-22/index.json",
            SourceCodeLink = null,

            Stack = new()
            {
                new StackItem("NextJS 14", "/assets/nextjs-original.svg", "Framework"),
                new StackItem("TypeScript", "/assets/typescript-original.svg", "Langage"),
                new StackItem("Node.js", "/assets/nodejs-original.svg", "Runtime"),
            },

            Contributions = new()
            {
                "Maîtrise de NextJS 14 et patterns modernes",
                "Développement full-stack React/Node.js",
                "Compréhension des API routes et Server Components",
                "TypeScript pour type-safety"
            },
            
            KeyMetrics = new()
            {
                "Apprentissage Rapide",
                "Full-Stack",
                "React Hooks"
            }
        },

        // ============================================
        // 4. CHARM: SALON DE COIFFURE APP (Production)
        // ============================================
        new BookData
        {
            Slug = "charm-salon",
            Title = "CHARM",
            Subtitle = "Gestion de salons de coiffure",
            ShelfMeta = "PHP Laravel • Flutter • Production",
            AccentColor = "#D4455E",
            StampLabel = "PROD 01",
            WidthPx = 72,
            HeightPx = 240,

            Role = "Backend Engineer & Architecte",
            Context = "BH Consulting (Freelance)",
            Year = "2025",
            Duration = "6 mois",

            DescriptionTitle = "Application commerciale en production",
            NarrationHtml = @"
                <p class=""drop-cap""><strong>Contexte :</strong> Les gérants de salons de coiffure au Togo manquaient d'outils modernes de gestion digitalisée.</p>
            
                <p><strong>Mission :</strong> Concevoir et développer CHARM, une application mobile complète de gestion de salons de coiffure.</p>
            
                <p><strong>Réalisations principales :</strong></p>
                <ul>
                    <li>Architecte principal : Conception complète de l'API REST en PHP Laravel</li>
                    <li>Architecture d'entreprise avancée : DDD + CQRS + SOLID + DRY appliqués</li>
                    <li>Domaine métier complexe modélisé : clients, rendez-vous, services, paiements, commissions</li>
                    <li>Authentification et autorisation sécurisées</li>
                    <li>Gestion des transactions critiques (paiements)</li>
                    <li>Publication sur Google Play Store et Apple App Store</li>
                </ul>

                <p><strong>Impact commercial :</strong></p>
                <ul>
                    <li>✅ Disponible sur Play Store et App Store</li>
                    <li>✅ Actuellement utilisée par plusieurs salons au Togo</li>
                    <li>✅ Génère des revenus pour les utilisateurs finaux</li>
                </ul>
            ",

            Sfx = "KRAK",
            Live2d = "/live2d/haruto/haruto.model.json",
            DemoLink = "https://style-charm.com/",
            SourceCodeLink = null, // Propriétaire

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
                "Design d'architecture avancée (DDD + CQRS + SOLID)",
                "Modélisation du domaine salon de coiffure",
                "Gestion des transactions et paiements",
                "Déploiement Play Store + App Store",
                "Support production et optimisations",
                "Contribution logique frontend Flutter"
            },
            
            KeyMetrics = new()
            {
                "Production Live",
                "Google Play & App Store",
                "Architecture DDD"
            }
        },

        // ============================================
        // 5. RECYCLE: SENSIBILISATION & COLLECTE
        // ============================================
        new BookData
        {
            Slug = "recycle-app",
            Title = "RECYCLE",
            Subtitle = "Sensibilisation et collecte collaborative",
            ShelfMeta = "PHP Laravel • Flutter • Gamification",
            AccentColor = "#22C55E",
            StampLabel = "PROD 02",
            WidthPx = 72,
            HeightPx = 240,

            Role = "Backend Engineer & Architecte",
            Context = "BH Consulting (Freelance)",
            Year = "2025",
            Duration = "6 mois (En cours)",

            DescriptionTitle = "Impact environnemental & engagement utilisateur",
            NarrationHtml = @"
                <p class=""drop-cap""><strong>Contexte :</strong> Besoin de sensibilisation des Togolais aux bonnes pratiques du recyclage et création d'un réseau de collecte collaborative.</p>
            
                <p><strong>Mission :</strong> Concevoir et développer RECYCLE, une application de sensibilisation au recyclage avec système de collecte collaborative et gamification.</p>
            
                <p><strong>Réalisations principales :</strong></p>
                <ul>
                    <li>Architecte principal : Conception complète de l'API REST en PHP Laravel</li>
                    <li>Architecture d'entreprise avancée : DDD + CQRS + SOLID + DRY</li>
                    <li>Domaine métier complexe : utilisateurs, points de collecte, types de déchets</li>
                    <li>Système de gamification : badges, leaderboards, scoring</li>
                    <li>Intégration de géolocalisation pour points de collecte</li>
                </ul>
            ",

            Sfx = "KRAK",
            Live2d = "/live2d/haruto/haruto.model.json",
            DemoLink = null, // Coming Soon
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
                "Design d'architecture avancée (DDD + CQRS + SOLID)",
                "Système de gamification complet",
                "Intégration de géolocalisation",
                "Logique de collecte collaborative",
                "Modélisation du domaine du recyclage",
                "Préparation pour déploiement multi-store"
            },

            KeyMetrics = new()
            {
                "Gamification",
                "Impact Social",
                "Géolocalisation"
            }
        },

        // ============================================
        // 6. ÉQUI-ASSIETTE: DIGIEDUHACK 2024 (Hackathon)
        // ============================================
        new BookData
        {
            Slug = "equi-assiette-hackathon",
            Title = "Équi-Assiette",
            Subtitle = "Application éducative de composition nutritionnelle",
            ShelfMeta = "NextJS • TypeScript • Education • Hackathon",
            AccentColor = "#FF6B6B",
            StampLabel = "HACK 25",
            WidthPx = 72,
            HeightPx = 240,

            // Détail
            Role = "Développeur Full-Stack & Soliste",
            Context = "DigiEduHack 2025",
            Year = "2025",
            Duration = "Hackathon",

            // Description riche
            DescriptionTitle = "Laboratoire numérique pour l'éducation nutritionnelle",
            NarrationHtml = """
                <p class="drop-cap"><strong>Contexte :</strong> L'analphabétisme nutritionnel est un moteur majeur de la crise de l'obésité et du diabète au Canada.</p>
            
                <p><strong>Solution :</strong> Équi-Assiette, une application web éducative qui transforme l'apprentissage passif en simulation active.</p>

                <p><strong>Concept clé :</strong></p>
                <ul>
                    <li>Les utilisateurs composent virtuellement leurs repas</li>
                    <li>Un moteur de règles avancé fournit un feedback instantané</li>
                    <li>Gamification complète : apprentissage par la pratique</li>
                </ul>
                """,

            Sfx = "KRAK",
            Live2d = "/live2d/koharu/koharu.model.json",
            DemoLink = "https://equi-assiette.vercel.app",
            SourceCodeLink = null,

            // Stack technique
            Stack = new()
            {
                new StackItem("NextJS 14", "/assets/nextjs-original.svg", "Framework"),
                new StackItem("TypeScript", "/assets/typescript-original.svg", "Langage"),
                new StackItem("React", "/assets/react-original.svg", "Library UI"),
            },

            Contributions = new()
            {
                "Conception et développement Full-Stack complet",
                "Architecture du moteur de règles",
                "Intégration API Open Food Facts",
                "Système de feedback gamifié",
                "Animations avec Framer Motion",
                "Design responsive pour web et mobile"
            },
            
            KeyMetrics = new() { "Hackathon Winner", "Gamification", "Health Tech" }
        },

        // ============================================
        // 7. ELAUD-COIFFURE: PLATEFORME DE RESERVATION
        // ============================================
        new BookData
        {
            Slug = "elaud-coiffure",
            Title = "Elaud-Coiffure",
            Subtitle = "Plateforme de gestion et réservation de salon",
            ShelfMeta = "NextJS • Prisma • Cloudinary • PostgreSQL",
            AccentColor = "#8B4513",
            StampLabel = "PROJ 25",
            WidthPx = 72,
            HeightPx = 240,

            Role = "Full-Stack Developer & Architecte",
            Context = "Projet Personnel",
            Year = "2025",
            Duration = "3 mois",

            DescriptionTitle = "Plateforme complète de gestion et réservation pour salons de coiffure",
            NarrationHtml = """
                <p class="drop-cap"><strong>Contexte :</strong> Les salons de coiffure canadiens manquent d'une solution moderne pour gérer les réservations de manière intégrée.</p>
            
                <p><strong>Solution :</strong> Elaud-Coiffure, une plateforme full-stack permettant aux clients de réserver en ligne et aux admins de gérer leur salon. Utilisation de Cloudinary pour l'hébergement performant des photos de coiffures.</p>

                <p><strong>Fonctionnalités :</strong></p>
                <ul>
                    <li>Système de réservation intuitif avec créneau horaire</li>
                    <li>Email de confirmation automatique (Cron Jobs)</li>
                    <li>Dashboard admin complet avec gestion du catalogue</li>
                    <li>Galerie de photos performante hébergée sur Cloudinary</li>
                </ul>
                """,

            Sfx = "KRAK",
            Live2d = "/live2d/koharu/koharu.model.json",
            DemoLink = "https://elaud-coiffure.vercel.app",
            SourceCodeLink = null,

            Stack = new()
            {
                new StackItem("NextJS 14", "/assets/nextjs-original.svg", "Framework full-stack"),
                new StackItem("TypeScript", "/assets/typescript-original.svg", "Langage"),
                new StackItem("PostgreSQL", "/assets/postgresql-original.svg", "Base de données"),
                new StackItem("Prisma", "/assets/prisma-original.svg", "ORM"),
                new StackItem("Cloudinary", "/assets/cloudinary-original.svg", "Hébergement médias"),
                new StackItem("Vercel", "/assets/vercel-original.svg", "Déploiement"),
            },

            Contributions = new()
            {
                "Architecture et développement full-stack complet",
                "Design et implémentation du système de réservation",
                "Intégration Cloudinary pour la gestion des photos",
                "Dashboard admin customizable",
                "Setup automation des rappels par email",
                "Déploiement et optimisation sur Vercel"
            },
            
            KeyMetrics = new() { "Dashboard Admin", "Cloudinary Hosting", "Vercel + Postgres" }
        },

        // ============================================
        // 8. INK UI: DESIGN SYSTEM (Portfolio)
        // ============================================
        new BookData
        {
            Slug = "ink-ui",
            Title = "Ink UI",
            Subtitle = "Portfolio Interactif",
            ShelfMeta = "Blazor • Tailwind CSS",
            AccentColor = "#4A2A18",
            StampLabel = "DEMO",
            WidthPx = 62, HeightPx = 232,
            
            Role = "Software Engineer",
            Context = "Portfolio Personnel",
            Year = "2025",
            Duration = "Permanent",
            Sfx = "POOF",
            Live2d = "/live2d/koharu/koharu.model.json",

            DescriptionTitle = "Expérimentation Visuelle Blazor & Tailwind",
            NarrationHtml = @"
                <p class=""drop-cap"">Ce portfolio est une démo technique alliant Blazor WebAssembly et Tailwind CSS.</p>
                <p>L'objectif était de créer une interface immersive style ""Manga/Encre"" en utilisant uniquement du CSS moderne (Grid, 3D Transforms) et la puissance des composants Blazor pour la logique.</p>",
            
            Stack = new List<StackItem>
            {
                new("Blazor", "/assets/blazor-original.svg", "Composants interactifs"),
                new("Tailwind CSS", "/assets/tailwindcss-original.svg", "Styling Utility-first"),
                new("C#", "/assets/csharp-original.svg", "Logique frontend"),
            },
            Contributions = new List<string>
            {
                "Architecture par composants Blazor réutilisables.",
                "Design System 'Ink' personnalisé avec Tailwind CSS.",
                "Optimisation des performances et animations GPU.",
                "Mode Offline-first avec Blazor WASM."
            },
            SourceCodeLink = null,
            KeyMetrics = new() { "Blazor WASM", "Tailwind CSS", "60 FPS" }
        }
    };

    public static List<BookData> GetAll() => _books;

    public static BookData? GetBySlug(string slug) 
    {
        return _books.FirstOrDefault(b => b.Slug.Equals(slug, System.StringComparison.OrdinalIgnoreCase));
    }

    public static BookData? GetNext(string slug)
    {
        var index = _books.FindIndex(b => b.Slug.Equals(slug, System.StringComparison.OrdinalIgnoreCase));
        if (index == -1 || index == _books.Count - 1) return null;
        return _books[index + 1];
    }

    public static BookData? GetPrevious(string slug)
    {
        var index = _books.FindIndex(b => b.Slug.Equals(slug, System.StringComparison.OrdinalIgnoreCase));
        if (index <= 0) return null;
        return _books[index - 1];
    }
}