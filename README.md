# POC Observers C#

> Design Patterns (Observer)

**Usage examples:** The Observer pattern is pretty common in C# code, especially in the GUI components. It provides a way to react to events happening in other objects without coupling to their classes.

https://refactoring.guru/design-patterns/observer/csharp/example#:~:text=Observer%20is%20a%20behavioral%20design,that%20implements%20a%20subscriber%20interface.

> Events and Delegates C#

**Usage examples:** Events enable a class or object to notify other classes or objects when something of interest occurs. The class that sends (or raises) the event is called the publisher and the classes that receive (or handle) the event are called subscribers.

https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/events/

> Service Bus (CoreEvent)

**Usage examples:** Is a good choice when you have lots of objects that are potential event sources. Rather than have the observer deal with registering with them all, you can centralize the registration logic to the Event Aggregator

Service out there!

- Azure Event Hubs
- Apache Kafka
- Google Cloud Pub/Sub
- RabbitMQ
- Amazon MQ

https://martinfowler.com/eaaDev/EventAggregator.html

https://github.com/erasmosoares/CoreEvent

> SignalR

SignalR is a free and open-source software library for Microsoft ASP.NET that allows server code to send asynchronous notifications to client-side web applications.

https://dotnet.microsoft.com/en-us/apps/aspnet/signalr
