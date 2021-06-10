using System;
public class PersonSecond
{
    private string name;
    public PersonSecond(string name)
    {
        this.name = name;
    }
    public void Show()
    {
        Console.WriteLine("装扮的{0}", name);
    }
}