using System;
class PersonThird
{
    private string name;

    public PersonThird()
    {

    }
    public PersonThird(string name)
    {
        this.name = name;
    }
    public virtual void Show()
    {
        Console.WriteLine("装扮的{0}",name);
    }
}