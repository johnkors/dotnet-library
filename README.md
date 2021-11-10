# dotnet-library

### Sample badges
[![Build](https://github.com/johnkors/dotnet-library/workflows/CI/badge.svg)](https://github.com/johnkors/dotnet-library/actions)
 [![NuGet](https://img.shields.io/nuget/v/SomeClassLib.svg)](https://www.nuget.org/packages/SomeClassLib/)
[![NuGet](https://img.shields.io/nuget/dt/SomeClassLib.svg)](https://www.nuget.org/packages/SomeClassLib/)


# What is this?

Template repo for setting up a simple .NET library (nuget) show casing some common use cases:


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
    - [Bundling internal dependencies: peer dependencies/transient dependencies (project refs) as dlls in main nuget without publish of peer to nuget.org](https://github.com/johnkors/dotnet-library/commit/979faec234391ba2fc807fc32d98909b50ed813b#diff-9f27cbfc298ab912ba6c38cf8282dfee1ea26c64b74771f899a1142a05e09cd4). See [#2](https://github.com/johnkors/dotnet-library/pull/2).
- Funding for GitHub Sponsors
- MIT License


