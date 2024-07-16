# OpenTelemetry Sample

[A practical introduction to OpenTelemetry for .NET developers (+ Aspire Dashboard) - YouTube](https://www.youtube.com/watch?v=HrRrJ5wTtdk&t=85s)

[Introduction to Distributed Tracing With OpenTelemetry in .NET](https://www.milanjovanovic.tech/blog/introduction-to-distributed-tracing-with-opentelemetry-in-dotnet)

## [OpenTelemetry Introduction](https://www.milanjovanovic.tech/blog/introduction-to-distributed-tracing-with-opentelemetry-in-dotnet#opentelemetry-introduction)

> [OpenTelemetry](https://opentelemetry.io/) (OTel) is a vendor-neutral, open-source standard for instrumenting applications to generate telemetry data. OpenTelemetry contains APIs, SDKs, tools, and integrations for creating and managing this telemetry data (traces, metrics, and logs).
>
> Telemetry data includes:
>
> - **Traces**: Represent the flow of requests through distributed systems, showing timings and relationships between services.
> - **Metrics**: Numerical measurements of system behavior over time (e.g., request counts, error rates, memory usage).
> - **Logs**: Textual records of events with rich contextual information. Structured logs.

## [What is OpenTelemetry? | OpenTelemetry](https://opentelemetry.io/docs/what-is-opentelemetry/)

OpenTelemetry is an [Observability](https://opentelemetry.io/docs/concepts/observability-primer/#what-is-observability) framework and toolkit designed to create and manage telemetry data such as [traces](https://opentelemetry.io/docs/concepts/signals/traces/), [metrics](https://opentelemetry.io/docs/concepts/signals/metrics/), and [logs](https://opentelemetry.io/docs/concepts/signals/logs/). Crucially, OpenTelemetry is vendor- and tool-agnostic, meaning that it can be used with a broad variety of Observability backends, including open source tools like [Jaeger](https://www.jaegertracing.io/) and [Prometheus](https://prometheus.io/), as well as commercial offerings.

## What is observability?

[Observability](https://opentelemetry.io/docs/concepts/observability-primer/#what-is-observability) is the ability to understand the internal state of a system by examining its outputs. In the context of software, this means being able to understand the internal state of a system by examining its telemetry data, which includes traces, metrics, and logs.

To make a system observable, it must be [instrumented](https://opentelemetry.io/docs/concepts/instrumentation). That is, the code must emit [traces](https://opentelemetry.io/docs/concepts/signals/traces/), [metrics](https://opentelemetry.io/docs/concepts/signals/metrics/), or [logs](https://opentelemetry.io/docs/concepts/signals/logs/). The instrumented data must then be sent to an observability backend.

## Solution Items

## `Directory.Build.props`

[What is this Directory.Build.props file all about? | Gary Woodfine](https://garywoodfine.com/what-is-this-directory-build-props-file-all-about/)

```xml
<Project>
  <!-- See https://aka.ms/dotnet/msbuild/customize for more details on customizing your build -->
  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <EnforceCodeStyleInBuild>true</EnforceCodeStyleInBuild>
  </PropertyGroup>
</Project>
```

```xml
<Project>
    <PropertyGroup>
        <Title>API Response</Title>
        <Authors>Gary Woodfine</Authors>
        <Description>Standardised API Response</Description>
        <RepositoryType>git</RepositoryType>
        <PackageTags>api project, api endpoints, response</PackageTags>
        <RepositoryUrl>https://github.com/threenine/apiResponse</RepositoryUrl>
        <PackageProjectUrl>https://threenine.co.uk</PackageProjectUrl>
        
        <TargetFramework>net6.0</TargetFramework>
        <LangVersion>10</LangVersion>
        <RootNamespace>Threenine</RootNamespace>

        <CodeAnalysisRuleset>$(MSBuildThisFileDirectory)MyRules.ruleset</CodeAnalysisRuleset>
    </PropertyGroup>
    <ItemGroup>                    
        <PackageReference Include="StyleCop.Analyzers" Version="1.1.118" />
        <AdditionalFiles Include="$(MSBuildThisFileDirectory)stylecop.json" />
    </ItemGroup>
</Project>
```

[Centralize .NET Project Settings using Directory.Build.Props and Directory.Package.Props | CodeNx](https://medium.com/codenx/centralize-net-project-settings-using-directory-build-props-and-directory-package-props-d6b4a471c018)

[Central Package Management | Microsoft Learn](https://learn.microsoft.com/en-us/nuget/consume-packages/central-package-management)

## Language Features

[What's new in C# 12 - Explore C# 12 | CodeNx](https://medium.com/codenx/exploring-the-new-features-in-c-12-2139f6d3737a)

- Primary Constructors
- Collection Expressions
- ref readonly parameters
- Default Lambda parameters
- Alias Any Type
- Inline Arrays
- Experimental Attribute
- Interceptors

```csharp
public class Person(string name, int age)
{
    public string Name { get; } = name;
    public int Age { get; } = age;

    public void Display() => Console.WriteLine($"Name: {Name}, Age: {Age}");
}

var person = new Person("Alice", 30);
person.Display(); // Output: Name: Alice, Age: 30
```

```csharp
// Create an array
int[] numbers = [1, 2, 3, 4, 5];

// Create a list
List<string> fruits = ["apple", "banana", "cherry"];

// Create a span
Span<char> letters = ['a', 'b', 'c', 'd'];

// Create a jagged array
int[][] jaggedArray = [[1, 2], [3, 4], [5, 6]];

// Use the spread operator to merge arrays
int[] mergedArray = [..numbers, ..jaggedArray[0]];
```

## Exception Handling

[Best Practices for Exception Handling in C# .NET | by p teja aswini | Jul, 2024 | Medium](https://tejaa916.medium.com/best-practices-for-exception-handling-in-c-net-bb9feae8c967)

## Migration from .NET 6 to .NET 8

[Seamless migration using .NET Upgrade Assistant to .NET 8 | CodeNx](https://medium.com/codenx/seamless-migration-using-net-upgrade-assistant-to-net-8-0c591c6602ee)
