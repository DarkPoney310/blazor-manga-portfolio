# Ink Portfolio — Isaac L. Lawson Attiogbe

[![CI](https://github.com/DarkPoney310/blazor-manga-portfolio/actions/workflows/ci.yml/badge.svg)](https://github.com/DarkPoney310/blazor-manga-portfolio/actions/workflows/ci.yml)

Portfolio personnel construit en **Blazor WebAssembly (.NET 10)**, avec un design
system « encre / manga » entièrement sur-mesure — **aucune librairie de composants**.

🔗 **Live :** http://manga-portfolio.runasp.net/ *(vérifier / remplacer par l'URL de production actuelle)*

---

## Pourquoi ce dépôt est public (et pas les autres)

La plupart de mes projets (MeloTogo, CHARM, E-Collecte…) sont sous **code propriétaire**
— NDA client ou produit commercial. Ce dépôt-ci est volontairement ouvert : il sert de
**vitrine de mes standards de code** (architecture, tests, CI), sur le seul projet dont
je détiens tous les droits.

---

## Stack technique

| Domaine        | Choix                                                        |
| -------------- | ----------------------------------------------------------- |
| Framework      | Blazor WebAssembly (.NET 10)                                 |
| Langage        | C# 13                                                        |
| Styling        | CSS moderne sur-mesure (Grid, transforms 3D) + Tailwind v4 (utilitaires uniquement) |
| Interop        | Modules JS ES6 (`ink.js`) pour transitions & observers      |
| Tests          | xUnit                                                        |
| CI             | GitHub Actions (build + test)                               |
| Hébergement    | IIS + pré-compression Brotli/Gzip                           |

## Points d'ingénierie notables

- **Payload réduit d'environ 8 Mo à ~2 Mo** au premier rendu : suppression des
  dépendances superflues, `InvariantGlobalization`, et service de fichiers
  **pré-compressés en Brotli** via `web.config`.
- **Design system « Ink » 100 % sur-mesure** : ~3 100 lignes de CSS, zéro composant tiers.
- **Navigation SPA avec transition « ink-wipe »** : l'interception des clics se fait en
  phase de capture côté JS, mais laisse passer Ctrl/Cmd/Shift/clic-milieu pour préserver
  le « ouvrir dans un nouvel onglet » natif (voir `Services/InkNavigator.cs`).
- **Catalogue de projets** modélisé en données (`Services/BookRepository.cs`) et projeté
  vers l'UI via un unique mapping `BookItem.From(...)` (pas de duplication).

## Architecture du projet

```
PortFolio/
├── Models/        # BookData, StackItem (records/POCO)
├── Services/      # BookRepository (catalogue), InkNavigator (transitions SPA)
├── components/    # Hero, About, Contact, Library, InkLink… (Razor)
├── Pages/         # Index, Library, LibraryBook, NotFound
├── Layout/        # MainLayout
└── wwwroot/       # CSS, JS, assets, web.config (Brotli + SPA fallback)

PortFolio.Tests/   # xUnit — tests unitaires du catalogue
```

## Démarrage local

Prérequis : [.NET 10 SDK](https://dotnet.microsoft.com/download).

```bash
# Restaurer et lancer
dotnet run --project PortFolio

# Lancer les tests
dotnet test

# (optionnel) Recompiler le CSS Tailwind utilitaire
cd PortFolio
npm install
npm run build:css
```

L'application démarre sur `https://localhost:7159`.

## Build de production

```bash
dotnet publish PortFolio -c Release
```

La sortie (`bin/Release/net10.0/publish/wwwroot`) contient les fichiers statiques et
leurs variantes pré-compressées `.br` / `.gz`, servies conditionnellement par les règles
de réécriture d'`wwwroot/web.config`.

## Licence

Code source sous licence MIT (voir `LICENSE`). Le contenu (textes, CV, visuels) reste la
propriété d'Isaac L. Lawson Attiogbe.
