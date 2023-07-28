using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Application.UseCaseServices
{
    public class Base
    {
        public void Write() { }
    }

    public partial class A : Base
    {
        public partial void AAA();
    }
    public partial class A
    {
        public A()
        {
            Write();
        }
        public partial void AAA() { }
    }
    public class TestService
    {
        public TestService()
        {
            IEnumerable<string> a = new List<string>();
            var x = new AA(1);
            x.Add(2);
        }
    }

    public readonly struct AA
    {
        public readonly int MyProperty { get; init; }

        public AA(int a)
        {
            MyProperty = a;
        }

        public int Add(int input)
        {
            input += MyProperty;
            return ++input;
        }
    }
}