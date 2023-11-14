namespace Northwind.Shared;

public class Animal
{
    [Coder("Bonny Price", "22 September 2022")]
    [Coder("Johnni Rasmussen", "13 September 2022")]
    [Obsolete($"use {nameof(SpeakBetter)} instead.")]
    public void Speak()
    {
        WriteLine("Woof...");
    }

    public void SpeakBetter()
    {
        WriteLine("Wooooooooof...");
    }
}
