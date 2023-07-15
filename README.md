## Dependency Injection (DI)

Dependency Injection (DI) in .NET Core is a design pattern and a built-in feature that allows the separation of dependencies from the classes that use them.

In DI, instead of directly creating and managing dependencies within a class, the dependencies are provided (injected) from built in DI container,.

The DI container keeps track of the registered services and their lifetimes, and it automatically resolves dependencies when requested.
- Transient Lifetime
- Scoped Lifetime
- Singleton Lifetime

### Advantage of DI

It enables loose coupling between classes, as they depend on abstractions (interfaces) rather than concrete implementations. This makes it easier to replace or modify dependencies without impacting the consuming classes.

## Service Lifetime

service lifetime refers to the lifespan or duration of a registered service within the DI container. It determines how long an instance of a service will be maintained.


### Transient
* A new instance of the service is created every time it is requested..
* Transient services are suitable for lightweight and stateless components that are not thread-safe or have a short lifespan.
>  Let's consider a  scenario where you have an application that needs to generate unique random codes for each customer request
### Scoped
* A single instance of the service is created and shared within the scope of an HTTP request or a specified scope. 
* Each new HTTP request or scope will receive a new instance of the service.
* Scoped services are commonly used for components that require per-request or per-scope state.
> Let's consider a scenario where you have a shopping cart in your web application that needs to persist across multiple requests within the scope of a user session.

### Singleton
* One instance for the entire lifetime of the application.A single instance of the service is created and shared throughout the lifetime of the application. 
* The same instance is used for all requests or scopes.
* Singleton services are suitable for stateless or thread-safe components that can be safely shared across multiple requests or scopes.
>  Let's consider a scenario where you have a logging service in your application that needs to be shared across all components and maintain a consistent state

### How to run

Run **dotnet watch** command inside the DILifeTime directory

### Screens
![DILifeTime.png](DILifeTime%2FImages%2FDILifeTime.png)
