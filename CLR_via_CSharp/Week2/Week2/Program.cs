Console.WriteLine("Welcome to Week 2!");

//this is just calling the consturcotr in two ways. I prefer the first, but VS perfers the latter
Donkey donkey = new Donkey("hee-haw");
Donkey lessVerboseDonkey = new("hee");


/*
 * 2. Uncomment out and fix the problem
 */
// Console.WriteLine(donkey._sound);
// Console.WriteLine(lessVerboseDonkey._sound);

/*
 * 1. Everything in C# is an object. The object gets converted to a type in the CLR. Try removing the comment below and see what happens
 */
class Donkey//: System.Object
{
    private String _sound { get; }

    public Donkey(String sound)
    {
        _sound = sound;
    }
}