using System;

namespace ProjectB
{
    public class Class1
    {
        public void A()
        {
            B();
        }

        [Weaver]
        public void B()
        {
            Console.WriteLine("I'm in B()");
        }
    }
}
