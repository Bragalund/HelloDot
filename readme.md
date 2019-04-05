# HelloDot

A project for showing off C# and .net core for a presentation.

## links used in presentation

[Link](https://github.com/dotnet/core) to the .net core repo. 
[Link](https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/install) to downloading and installing .net core CLI and a little hello-world tutorial.

## How to run

All commands are run from root folder.

### Dotnet cli

```()
dotnet run -p helloDotApi
```

### Docker

```()
docker build helloDotApi/Dockerfile;
docker run -p 80:8080 <containerId>;
```
