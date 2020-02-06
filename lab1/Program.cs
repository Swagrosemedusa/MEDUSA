using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class A
    {

    }
    class B
    {
        object a1;
        object a2;
        public B(object a1, object a2)
        {
            this.a1 = a1;
            this.a2 = a2;
        }
    }
    class C : B
    {
        object b1;

        public C(object a1, object a2, object b1) 
            : base(a1, a2)
        
        {
            this.b1 = b1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new C(new A(), new A(), new B(new A(), new A()));
        }
    }
}
