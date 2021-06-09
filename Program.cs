using System;

namespace DesignPatternLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 简单工厂模式

            // Calculator calculator=new Calculator();
            // calculator.First(); //计算器第一版
            // calculator.Second();
            // calculator.Third();
            // calculator.Fourth();

            #endregion

            #region 策略模式

            Context context;

            context=new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context=new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context=new Context(new ConcreteStrategyC());
            context.ContextInterface();

            #endregion
        }
    }
}
