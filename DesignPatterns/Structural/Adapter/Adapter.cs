using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class AdapteeA
    {
        public void UseAdapteeA() { Console.WriteLine("Using Adaptee A."); }
    }

    public class AdapteeB
    {
        public void UseAdapteeB() { Console.WriteLine("Using Adaptee B."); }
    }

    public interface ITarget
    {
        void Method();
    }
    public class AdapterA : ITarget
    {
        AdapteeA adaptee = new AdapteeA();
        public void Method() { adaptee.UseAdapteeA(); }
    }

    public class AdapterB : ITarget
    {
        AdapteeB adaptee = new AdapteeB();
        public void Method() { adaptee.UseAdapteeB(); }
    }
}
