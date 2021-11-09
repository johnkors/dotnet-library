# dotnet-library

Template repo for setting up a simple .NET library show casing some common use cases:


- GitHub actions (CI, deploy)
  - CI : Restore, build & unit tests via Xunit
  - Pre-release:
      - Automated publishing of pre-release versions to nuget.org
      - Semver-versioning via GitVersion
      - Manually triggered workflow
  - Release:
      - Same as Pre-release, + publish a Github release w/ release notes using the GitHub Release Notes API.
- A sensible `.editorconfig` for csharp
- A sensible `.gitignore`for .NET projects
- Commonly setup Nuget package contents:
    - Package icon (embedded in nuget)
    - Readme showing in nuget.org (embedded in nuget),
    - Multi-targeting and conditional dependencies dep on TFM
- Funding for Github Sponsors
- MIT License


