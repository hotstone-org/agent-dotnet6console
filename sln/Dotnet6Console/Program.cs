// See https://aka.ms/new-console-template for more information

using Dotnet6Console;

var dotnetVersion = 6;

var creator = new MessageCreator();
Console.WriteLine(creator.Create(dotnetVersion));
