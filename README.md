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
