# Frends.Community.Echo

FRENDS Community Task for Echo
---#if (EnableCommunityTask)

<li><a asp-area="" asp-controller="Home" asp-action="Contact">Contact</a></li>
 [![Actions Status](https://github.com/CommunityHiQ/Frends.Community.Echo/workflows/PackAndPushAfterMerge/badge.svg)](https://github.com/CommunityHiQ/Frends.Community.Echo/actions) ![MyGet](https://img.shields.io/myget/frends-community/v/Frends.Community.Echo) [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT) 
---#endif

- [Installing](#installing)
- [Tasks](#tasks)
     - [Echo](#Echo)
- [Building](#building)
- [Contributing](#contributing)
- [Change Log](#change-log)

# Installing

---#if (EnableCommunityTask)
You can install the task via FRENDS UI Task View or you can find the NuGet package from the following NuGet feed
https://www.myget.org/F/frends-community/api/v3/index.json and in Gallery view in MyGet https://www.myget.org/feed/frends-community/package/nuget/Frends.Community.Echo
---#else
You can install the task via FRENDS UI Task View by using `Import Task NuGet` button in Administration > Tasks.
---#endif

# Tasks

## Echo

Repeats message

### Properties

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| Message | `string` | Some string that will be repeated. | `foo` |

### Options

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| Amount | `int` | Amount how many times message is repeated. | `3` |
| Delimiter | `string` | Character(s) used between replications. | `, ` |

### Returns

A result object with parameters.

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| Replication | `string` | Repeated string. | `foo, foo, foo` |

Usage:
To fetch result use syntax:

`#result.Replication`

# Building

---#if (EnableCommunityTask)
Clone a copy of the repo

`git clone https://github.com/CommunityHiQ/Frends.Community.Echo.git`
---#endif

Rebuild the project

`dotnet build`

Run Tests

`dotnet test`

Create a NuGet package

`dotnet pack --configuration Release`

# Contributing
When contributing to this repository, please first discuss the change you wish to make via issue, email, or any other method with the owners of this repository before making a change.

1. Fork the repo on GitHub
2. Clone the project to your own machine
3. Commit changes to your own branch
4. Push your work back up to your fork
5. Submit a Pull request so that we can review your changes

NOTE: Be sure to merge the latest from "upstream" before making a pull request!

# Change Log

| Version | Changes |
| ------- | ------- |
| 0.0.1   | Development stil going on. |
