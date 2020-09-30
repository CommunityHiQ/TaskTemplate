# Frends Task template

![](https://github.com/CommunityHiQ/Frends.Community.Echo/workflows/AutoBuildMAster/badge.svg) ![NuGet](https://img.shields.io/nuget/v/frendstask) [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

This template can be used to create both community and custom Tasks for [frends](frends.com) integration platform. This enables you to start writing code without any hassle with project formats etc.

The created C# solution will use the new tool chain (dotnet new etc.) from .NET Core SDK to ensure cross-platform compatibility. 

You can learn more about custom Tasks [here](https://docs.frends.com/en/articles/2206746-custom-tasks) and about community Tasks [here](https://github.com/CommunityHiQ/Instructions).

## Prerequisite

This template is based on .NET Core CLI tools, so you need to have .NET Core 2.1 SDK or newer. As it is having reaching end of support in 2021-08-21 it is preferably to use [.NET Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/3.1).

In addition you will need [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472) if you want to be able to create multitarget or .NET Framework frends Tasks. If you are unsure about anything in the previous sentence and you are using Windows machine to develop Tasks, you will most probably want to create multitargeting tasks.

Frends tasks are mainly coded in C#, so you will also need a developing environment for it. Visual Studio, Visual Studio Code, and Rider the most widely used ones, but any text editor will do as you can compile from [console](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-build). If you are using Visual Studio you can also use, to develop frends Task, old Non-SDK style project files, and MSBuild and nuget.exe technologies. This way you would not need .NET Core 2.1 SDK, but then you are not able to create cross-platform tasks, and creating that kind of C# projects is not supported by this template. 

Unfortunately, Visual Studio or other IDEs do not currently support dotnet new templates, so you need to use the command line to install the template and create new tasks based on it.


## Install the template

You can install the template by following the command

`dotnet new -i frendstask`

## Create a new custom task

You can create a new task by the following command

`dotnet new frendstask --name namespaceForTask --className classNameForTask --taskName TaskName --license UNLICENSED --authors $env:UserName`

The license can be anything listed in https://spdx.org/licenses/ or UNLICENSED.

## Create a new Community task

If you want to make Tasks that can be published in https://github.com/CommunityHiQ/ and setup Continuous integration related to Community tasks you can use the following command.

`dotnet new frendstask --name Frends.Community.Echo --className Echo --taskName ExecuteEcho --EnableCommunityTask true`

**Always remember to add prefix Frends.Community to namespace when creating a community task and to set EnableCommunityTask to true. Always use MIT license for community Tasks. It is the default on, so you can omit the license parameter.**

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

This command will build the project and create a NuGet package `.\bin\Debug\frendstask.*.*.*.nupkg` You can ignore warnings about Frends.Community.Echo.SetPaswordsEnv.ps1.

To install this template from locally created NuGet package use

`dotnet new -i <ABSOLUTE_PATH_TO_NUPKG_FILE>`


## Special notes about this repository

URL https://github.com/CommunityHiQ/Frends.Community.Echo redirects here 

