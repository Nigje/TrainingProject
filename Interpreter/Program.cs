using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context=new Context(100,200);
            List<Expression> expressions=new List<Expression>();
            expressions.Add(new Bazar());
            expressions.Add(new Bourse());
            foreach (Expression expression in expressions)
            {
                expression.Interpret(context);
            }
            Console.WriteLine(context.Value);
        }
    }
    //******************************************************************
    public class Context
    {
        public Context(int count, int price)
        {
            Count = count;
            Price = price;
        }
        public int Count { get; set; }
        public int Price { get; set; }
        public int Value { get; set; }
    }

    //******************************************************************
    public abstract class Expression
    {
        public void Interpret(Context contex)
        {
            contex.Value += (int)(contex.Count * contex.Price * (Tax() + Karmoz()));
        }
        public abstract double Tax();
        public abstract double Karmoz();
    }
    //******************************************************************
    public class Bazar : Expression
    {
        public override double Karmoz()
        {
            return 0.003;
        }

        public override double Tax()
        {
            return 0;
        }
    }
    //******************************************************************
    public class Bourse : Expression
    {
        public override double Karmoz()
        {
            return 0.002;
        }

        public override double Tax()
        {
            return 0.001;
        }
    }


}
