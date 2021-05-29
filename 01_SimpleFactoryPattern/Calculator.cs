using System;
public class Calculator
{

    public void First()
    {
        Console.Write("请输入数字A：");
        string A = Console.ReadLine();
        Console.Write("请选择运算符号（+、-、*、/）:");
        string B = Console.ReadLine();
        Console.Write("请输入数字B：");
        string C = Console.ReadLine();
        string D = "";

        if (B == "+")
        {
            D = Convert.ToString(Convert.ToDouble(A) + Convert.ToDouble(C));
        }
        if (B == "-")
        {
            D = Convert.ToString(Convert.ToDouble(A) - Convert.ToDouble(C));
        }
        if (B == "*")
        {
            D = Convert.ToString(Convert.ToDouble(A) * Convert.ToDouble(C));
        }
        if (B == "/")
        {
            D = Convert.ToString(Convert.ToDouble(A) / Convert.ToDouble(C));
        }

        Console.WriteLine("结果是：" + D);
    }

    public void Second()
    {
        try
        {
            Console.Write("请输入数字A:");
            string strNumberA = Console.ReadLine();
            Console.Write("请选择运算符号（+、-、*、/）：");
            string strOperate = Console.ReadLine();
            Console.Write("请输入数字B：");

            string strNumberB = Console.ReadLine();
            string strResult = "";

            switch (strOperate)
            {
                case "+":
                    strResult = Convert.ToString(Convert.ToDouble(strNumberA) + Convert.ToDouble(strNumberB));
                    break;
                case "-":
                    strResult = Convert.ToString(Convert.ToDouble(strNumberA) - Convert.ToDouble(strNumberB));
                    break;
                case "*":
                    strResult = Convert.ToString(Convert.ToDouble(strNumberA) * Convert.ToDouble(strNumberB));
                    break;
                case "/":
                    if (strNumberB != "0")
                    {
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) / Convert.ToDouble(strNumberB));
                    }
                    else
                    {
                        strResult = "除数不能为0";
                    }
                    break;
            }
            Console.WriteLine("结果是：" + strResult);
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine("您的输入有错：" + ex.Message);
        }
    }

    public void Third()
    {
        try
        {
            Console.Write("请输入数字A：");
            string strNumberA = Console.ReadLine();
            Console.Write("请选择运算符号（+、-、*、/）：");
            string strOperate = Console.ReadLine();
            Console.Write("请输入数字B：");
            string strNumberB = Console.ReadLine();

            string strResult = "";
            strResult = Convert.ToString(OperationFirst.GetResult(Convert.ToDouble(strNumberA), Convert.ToDouble(strNumberB), strOperate));
            Console.WriteLine("结果是：" + strResult);
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine("您的输入有错：" + ex.Message);
        }

    }
    public void Fourth()
    {
        try
        {
            OperationTwo oper;
            Console.Write("请输入数字A：");
            string strNumberA = Console.ReadLine();
            Console.Write("请选择运算符号（+、-、*、/）：");
            string strOperate = Console.ReadLine();
            oper = OperationFactory.createOperate(strOperate);
            oper.NumberA = Convert.ToDouble(strNumberA);
            Console.Write("请输入数字B：");
            oper.NumberB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("结果是：" + oper.GetResult());
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine("您的输入有错：" + ex.Message);
        }
    }
}
public class OperationFirst
{
    public static double GetResult(double numberA, double numberB, string operate)
    {
        double result = 0d;

        switch (operate)
        {
            case "+":
                result = numberA + numberB;
                break;
            case "-":
                result = numberA - numberB;
                break;
            case "*":
                result = numberA * numberB;
                break;
            case "/":
                result = numberA / numberB;
                break;

        }
        return result;
    }
}
public class OperationTwo
{
    private double _numberA = 0;
    private double _numberB = 0;
    public double NumberA
    {
        get { return _numberA; }
        set { _numberA = value; }
    }
    public double NumberB
    {
        get { return _numberB; }
        set { _numberA = value; }
    }
    public virtual double GetResult()
    {
        double result = 0;
        return result;
    }
}
public class OperationAdd : OperationTwo
{
    public override double GetResult()
    {
        double result = 0;
        result = NumberA + NumberB;
        return result;
    }
}
public class OperationSub : OperationTwo
{
    public override double GetResult()
    {
        double result = 0;
        result = NumberA - NumberB;
        return result;
    }
}
public class OperationMul : OperationTwo
{
    public override double GetResult()
    {
        double result = 0;
        result = NumberA * NumberB;
        return result;
    }
}
public class OperationDiv : OperationTwo
{
    public override double GetResult()
    {
        double result = 0;
        if (NumberB == 0)
        {
            throw new Exception("除数不能为0。");
        }
        result = NumberA / NumberB;
        return result;
    }
}
public class OperationFactory
{
    public static OperationTwo createOperate(string operate)
    {
        OperationTwo oper = null;
        switch (operate)
        {
            case "+":
                oper = new OperationAdd();
                break;
            case "-":
                oper = new OperationSub();
                break;
            case "*":
                oper = new OperationMul();
                break;
            case "/":
                oper = new OperationDiv();
                break;
        }
        return oper;
    }
}