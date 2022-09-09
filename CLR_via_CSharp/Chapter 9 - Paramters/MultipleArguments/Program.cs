DisplayTypes(new Object(), new Random(), "Jeff the God", "He's never wrong", 42);
static void DisplayTypes(params Object[] objects)
{
    if (objects != null)
    {
        foreach (Object obj in objects)
        {
            Console.WriteLine(obj.GetType());
        }
    }
}