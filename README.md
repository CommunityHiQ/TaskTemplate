# Frends task template


![](https://github.com/CommunityHiQ/Frends.Community.Echo/workflows/AutoBuildMAster/badge.svg) ![Nuget](https://img.shields.io/nuget/v/frendstask) [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

This template can be used to create both community and custom task for [FRENDS](frends.com) integration paltform. This should enamble you to start writing code without any hastle with project formats etc.

Created C# solution will use new tool chain from .Net technologies to ensure compatiblity with .Net with crossplatform. 

You can learn more about custom task [here](https://docs.frends.com/en/articles/2206746-custom-tasks) and from community tasks [here](https://github.com/CommunityHiQ/Instructions).


## Install template

`dotnet new -i frendstask`

## Create a new Community task

`dotnet new frendstask --name Frends.Community.Echo --className Echo --taskName ExecuteEcho --EnableCommunityTask true`

**Always remember to add prefix Frends.Community to namespace when creating a community task and to set EnableCommunityTask to true.**

## Create a new custom task

`dotnet new frendstask --name namespaceForTask --className classNameForTask --taskName TaskName --license UNLICENSED --authors $env:UserName`

Custom task do not include CI things that are used in Community tasks. License can be anything listed in: https://spdx.org/licenses/ or UNLICENSED.

## Get help using template

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


Community task template (C#)
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
                                netstandard2.0;net471    - Target both .Net standard 2.0 and .NET Framework 4.7.1
                                netstandard2.0           - .Net standard 2.0
                                net471                   - .NET Framework 4.7.1
                            Default: netstandard2.0;net471
```

## Update template

`dotnet new frendstask --update-apply `

## Uninstall template

`dotnet new -u frendstask`

## Building this repository

`dotnet pack`

This command will build the project and create a NuGet package in .\bin\Debug 

`dotnet new -i <ABSOLUTE_PATH_TO_NUPKG_FILE>`


## special notes about this repository

URL https://github.com/CommunityHiQ/Frends.Community.Echo redirects here 

