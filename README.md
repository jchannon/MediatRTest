# MediatRTest

Uses [MediatR](https://github.com/jbogard/MediatR) to return an instance of a type directly rather than calling into container but calls the reflection code `handlerType.MakeGenericType` inside MediatR.

After load testing a web app I have a gut feeling that reflection on mono is poor, this comes from testing the said web app with no, small and large dependencies injected into a http route handler via an IOC Container.

## Results

    Windows 8 / .Net 4.5.1 = 47 ms
    OSX 10.10.5 / Mono 4.2 = 101 ms
    OSX 10.10.5 / Mono 3.12.1 = 108 ms
