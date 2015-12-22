# MediatRTest

Uses [MediatR](https://github.com/jbogard/MediatR) to return an instance of a type directly rather than calling into an IOC container but calls the reflection code `handlerType.MakeGenericType` inside MediatR.

After load testing a web app I have a gut feeling that reflection on Mono is poor, this comes from testing the said web app with no, small and large dependencies injected into a http route handler via an IOC Container.  Performance increases with less reflection required by an IOC Container.

This my poor attempt to prove there is an issue with reflection on Mono.

## Results

    Windows 8 / .Net 4.5.1 = 47 ms
    OSX 10.10.5 / Mono 4.2 = 101 ms
    OSX 10.10.5 / Mono 3.12.1 = 108 ms
    OSX 10.10.5 / 1.0.0-rc2-16343 coreclr x64 = 93ms
