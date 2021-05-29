using System;

//具体算法A
class ConcreteStrategyA:Strategy
{
    //算法A实现方法
    public override void AlgorithmInterface()
    {
        Console.WriteLine("算法A的实现");
    }
}
//具体算法B
class ConcreteStrategyB:Strategy
{
    //算法B实现方法
    public override void AlgorithmInterface()
    {
        Console.WriteLine("算法B的实现");
    }
}
//具体算法C
class ConcreteStrategyC:Strategy
{
    //算法C实现方法 
    public override void AlgorithmInterface()
    {
        Console.WriteLine("算法C的实现");
    }
}