# Frends Task template


![](https://github.com/CommunityHiQ/Frends.Community.Echo/workflows/AutoBuildMAster/badge.svg) ![NuGet](https://img.shields.io/nuget/v/frendstask) [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

This template can be used to create both community and custom Tasks for [frends](frends.com) integration platform. This enables you to start writing code without any hassle with project formats etc.

The created C# solution will use the new tool chain (dotnet new etc.) from .NET Core SDK to ensure cross-platform compatibility. 

You can learn more about custom Tasks [here](https://docs.frends.com/en/articles/2206746-custom-tasks) and about community Tasks [here](https://github.com/CommunityHiQ/Instructions).

## Install the template

`dotnet new -i frendstask`

## Create a new Community Task

`dotnet new frendstask --name Frends.Community.Echo --className Echo --taskName ExecuteEcho --EnableCommunityTask true`

**Always remember to add the prefix Frends.Community to namespace when creating a community Task and to set EnableCommunityTask to true.**

## Create a new custom Task

`dotnet new frendstask --name namespaceForTask --className classNameForTask --taskName TaskName --license UNLICENSED --authors $env:UserName`

The custom Task does not include CI related functionality which is used in Community Tasks. License can be anything listed in: https://spdx.org/licenses/ or UNLICENSED, but community Tasks should use the MIT license.

## Get help using the template

`dotnet new frendstask -h`

Example output:

```
Usage: new [options]

Options:
  -h, --help          Displays help for this command.
  -l, --list          Lists templates containing the specified name. If no name is specified, lists all templates.
  -n, --name          The name for the output being created. If no name is specified, the name of the current directory is used.
  -o, --output        Location to place the generated output.
  -i, --install       Installs a source or a template pack.
  -u, --uninstall     Uninstalls a source or a template pack.
  --nuget-source      Specifies a NuGet source to use during install.
  --type              Filters templates based on available types. Predefined values are "project", "item" or "other".
  --dry-run           Displays a summary of what would happen if the given command line were run if it would result in a template creation.
  --force             Forces content to be generated even if it would change existing files.
  -lang, --language   Filters templates based on language and specifies the language of the template to create.
  --update-check      Check the currently installed template packs for updates.
  --update-apply      Check the currently installed template packs for update, and install the updates.


Community Task template (C#)
Author: HiQ Finland
Options:
  -t|--taskName
                            string - Optional
                            Default: ExecuteEcho

  -c|--className
                            string - Optional
                            Default: Echo

  -au|--authors
                            string - Optional
                            Default: HiQ Finland

  -li|--license
                            string - Optional
                            Default: MIT

  -E|--EnableCommunityTask
                            bool - Optional
                            Default: true

  -T|--TargetPlatform
                                netstandard2.0;net471    - Target both .NET Standard 2.0 and .NET Framework 4.7.1
                                netstandard2.0           - .NET Standard 2.0
                                net471                   - .NET Framework 4.7.1
                            Default: netstandard2.0;net471

```

## Update the template

`dotnet new frendstask --update-apply `

## Uninstall the template

`dotnet new -u frendstask`

## Building this repository

`dotnet pack`

This command will build the project and create a NuGet package in .\bin\Debug 

To install this template from locally created NuGet package use

`dotnet new -i <ABSOLUTE_PATH_TO_NUPKG_FILE>`


## Special notes about this repository

URL https://github.com/CommunityHiQ/Frends.Community.Echo redirects here 

