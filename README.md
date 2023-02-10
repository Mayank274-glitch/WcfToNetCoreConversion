# WcfToNetCore

Agenda of this project

We want convert any existing wcf service to .net core api in large scale project without breaking existing customers.


WcfConsumer project- We are asuming this a dummy customer.

WcfConversion project - We are asuming this new .Net Core Api.

WcfServiceTest2 project - We are asuming this existing wcf service which needs to be converted.


Solution is creating a DynamicRouteValueTransformer Class for .net core api
(Check more info here - https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.routing.dynamicroutevaluetransformer?view=aspnetcore-7.0)


Major advantages of converting - it can run on any platform, like linux not just on windows, which can save big cost in terms of large scale projects.
