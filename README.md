# Frends task template

This template can be used to create both community and custom task for (FRENDS)[frends.com] integration paltform. This should enamble you to start writing code without any hastle with project formats etc.

Created C# solution will use new tool chain from .Net technologies to ensure compatiblity with .Net with crossplatform. 

You can learn more about custom task (here)[https://docs.frends.com/en/articles/2206746-custom-tasks] and from community tasks (here)[https://github.com/CommunityHiQ/Instructions].


## Install template

`dotnet new -i frendstasktemplate`

## Create new task with template

`dotnet new frendstasktemplate -n YourTaskName`

## Get help using template

`dotnet new frendstasktemplate -h`

Example output:

## Uninstall template

`dotnet new -u frendstasktemplate`

## Create template from this repository

`dotnet pack`

This command will build the project and create a NuGet package in .\bin\Debug 

`dotnet new -i <ABSOLUTE_PATH_TO_NUPKG_FILE>`

## Changing target framework

Created project targets .Net standard 2.0. If you  want to target framework or both standard and framewrok you can set 

`<TargetFramework>netstandard2.0</TargetFramework>`

to

`<TargetFrameworks>net461</TargetFrameworks>`

or 

`<TargetFrameworks>netstandard2.0;net461</TargetFrameworks>`

.csproj file that is crated for you.

## special notes about this repository

URL https://github.com/CommunityHiQ/Frends.Community.Echo redirects here 

