﻿Console.WriteLine("Welcome to Week 2!");

//this is just calling the constructor in two ways. I prefer the first, but VS prefers the latter
Donkey donkey = new Donkey("hee-haw");
Donkey lessVerboseDonkey = new("hee");


/*
 * 2. Uncomment out and fix the problem
 */
// Console.WriteLine(donkey.Sound);
// Console.WriteLine(lessVerboseDonkey.Sound);

/*
 *
 * run ildasm in the developer powershell and see the difference between both to see the type differences
 */

/*
 * 1. Everything in C# is an object. The object gets converted to a type in the CLR.
 * 
 */
class Donkey//: System.Object
{
    private String Sound { get; }

    public Donkey(String sound)
    {
        Sound = sound;
    }
}