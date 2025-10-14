# DotNet.CICDTest

This repo exists to provide a testing ground for the following GitHub aciton workflows:

- [dotnet-continuous-integration](https://github.com/jmsudar/dotnet-continuous-integration)
- [dotnet-continuous-deployment](https://github.com/jmsudar/dotnet-continous-deployment)

This library project is not meant to be a useful tool nor solve any problems through the library itself. Instead, it contains a very simple Hello, World! method along with a unit test. These methods are unlikely to change, as their simplicity and predictability make the purpose of this repo easier to test.

Changes to either the .NET CI or CD actions up above will then be reflected with a version listed in the table below. 

### `dotnet-continuous-integration`

Updating the README and opening a PR will then kick off a run of `dotnet-continuous-integration`. This is a simple github action that performs the following steps:

1. Checks out the repo.
2. Installs .NET in whichever version you specify (at time of writing, default is .NET 6.0).
3. Performs a `dotnet restore`.
4. Builds the projects with the specified configuration (defaults to `Release`).
5. Runs `dotnet test` at the specified verbosity (defaults to `normal`).

These actions ensure that a .NET library that uses this CI action can build, and that all unit tests will succeed. Setting this action as a check on your repo's protected branches will then guarantee changes, and allow CD to proceed successfully after merge.

#### Testing Failure

To test the failure state and the formatting of the output, there are a couple of lines to uncomment for the purposes of testing success, failure, and formatting of both.

Success and failure is marked in comments, either `successful test case` or `failure test case`.

### `dotnet-continous-deployment`

Merging the PR that tests `dotnet-continous-integration` will continue the process and create a NuGet package push and publish. The following steps take place:

1. Rerun `dotnet-continuous-integration` to verify the code being published can build and passes all tests. This will also test that a repository variable, `NUGET_API_KEY` is present, which is required for the publish step.
2. 

## Testing versions

The table below indicates what is being tested. New entries in this table correspond to improvements in either action. The columns are

- `Date`: The date of the work being done
- `dotnet-ci`: The branch being in `dotnet-ci`, if applicable
- `dotnet-cd`: The branch being in `dotnet-cd`, if applicable
- `Description`: A description of the work being done

| Date | `dotnet-ci` | `dotnet-cd` | Description |
| :-: | :-: | :-: | :- |
| 7/20/2025 | jms-integrate-test-repo | jms-integrate-test-repo | Initial implementation of this test repo. Tests new formatting options within `dotnet-ci`, and tests end-to-end readiness of `dotnet-cd`.