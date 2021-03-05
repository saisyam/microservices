# Creating a microservice with .Net core SDK
In this section we will build a very simple web service. Consider this as a boilerplate for our future projects.

## Install `dotnet` SDK
Install .Net 5.0 SDK from [here](https://dotnet.microsoft.com/download). If installed successfully, run the following command:

```shell
~$ dotnet
Usage: dotnet [options]
Usage: dotnet [path-to-application]

Options:
  -h|--help         Display help.
  --info            Display .NET information.
  --list-sdks       Display the installed SDKs.
  --list-runtimes   Display the installed runtimes.

path-to-application:
  The path to an application .dll file to execute.
```
## Create a web service
Run the following command to create a webapi:

```shell
~$ dotnet new webapi -o sampleService --no-https
```
The `sampleService` project will display some information about a `Github` user. The biolerplate returns hard coded values which will be eventually replaced by calling the `Github` API. To run the service:

```shell
~$ cd sampleService
~$ dotnet run
```
The application will run at `http://localhost:5000`. You can access the data from the URL, `http://localhost:5000/GithubUserInfo`.
