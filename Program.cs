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

            // Context context;

            // context = new Context(new ConcreteStrategyA());
            // context.ContextInterface();

            // context = new Context(new ConcreteStrategyB());
            // context.ContextInterface();

            // context = new Context(new ConcreteStrategyC());
            // context.ContextInterface();

            #endregion

            #region 装饰模式

            #region 小菜扮靓（未使用前第一版）

            // PersonFirst xc = new PersonFirst("小菜");
            // Console.WriteLine("\n第一种装扮：");

            // xc.WearTShirts();
            // xc.WearBigTrouser();
            // xc.WearSneakers();
            // xc.Show();

            // Console.WriteLine("\n第二种装扮：");
            // xc.WearSuit();
            // xc.WearTie();
            // xc.WearLeatherShoes();
            // xc.Show();

            // Console.Read();
            #endregion

            #region  小菜扮靓（未使用前第二版）

            // PersonSecond xc = new PersonSecond("小菜");

            // Console.WriteLine("/n第一种装扮：");
            // Finery dtx = new TShirts();
            // Finery kk = new BigTrouser();
            // Finery pqx = new Sneakers();
            // dtx.Show();
            // kk.Show();
            // pqx.Show();
            // xc.Show();

            // Console.WriteLine("/n第二种装扮：");
            // Finery xz = new Suit();
            // Finery ld = new Tie();
            // Finery px = new LeatherShoes();

            // xz.Show();
            // ld.Show();
            // px.Show();
            // xc.Show();

            #endregion

            #region 例子

            // ConcreteComponent c=new ConcreteComponent();
            // ConcreateDecoretorA d1=new ConcreateDecoretorA();
            // ConcreateDecoretorB d2=new ConcreateDecoretorB();

            // d1.SetComponent(c);
            // d2.SetComponent(d1);
            // d2.Operation();

            #endregion

            #region 小菜扮靓（使用后）

            PersonThird xc = new PersonThird("小菜");

            Console.WriteLine("\n第一种装扮：");

            SneakersThird pqx = new SneakersThird();
            BigTrouserThird kk = new BigTrouserThird();
            TShirtsThird dtx = new TShirtsThird();

            pqx.Decorate(xc);
            kk.Decorate(pqx);
            dtx.Decorate(kk);
            dtx.Show();

            Console.WriteLine("\n第二种装扮：");

            LeatherShoesThird px=new LeatherShoesThird();
            TieThird ld=new TieThird();
            SuitThird xz=new SuitThird();

            px.Decorate(xc);
            ld.Decorate(px);
            xz.Decorate(ld);
            xz.Show();
            

            #endregion

            #endregion
        }
    }
}
