# MockableHttp
A mockable wrapper for System.Net.Http.HttpClient.

## Getting started
Install the NuGet package into your application.

### Package Manager
```
Install-Package MockableHttp
```

### .NET CLI
```
dotnet add package MockableHttp
```

## Usage
The `IHttpService` interface exposes properties and methods mirroring `System.Net.Http.HttpClient` and allows it to be
mocked during testing.

The concrete `HttpService` class implements `IHttpService` and forwards calls to `System.Net.Http.HttpClient` for use in
production.
