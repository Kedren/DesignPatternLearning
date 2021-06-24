using System;
class ConcreateDecoretorA : Decoretor
{
    private string addedState;
    public override void Operation()
    {
        base.Operation();
        addedState="New State";
        Console.WriteLine("具体装饰对象A的操作");
    }
}
class ConcreateDecoretorB : Decoretor
{
    public override void Operation()
    {
        base.Operation();
        AddedBehavior();
        Console.WriteLine("具体装饰对象B的操作");
    }
    private void AddedBehavior()
    {

    }
}