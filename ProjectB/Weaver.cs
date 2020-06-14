using MethodDecorator.Fody.Interfaces;
using System;
using System.Reflection;

namespace ProjectB
{
    class Weaver : Attribute, IMethodDecorator
    {
        public void Init(object instance, MethodBase method, object[] args)
        {
            Console.WriteLine("Init");
        }

        public void OnEntry()
        {
            Console.WriteLine("Entry");
        }

        public void OnException(Exception exception)
        {
            Console.WriteLine("Exception");
        }

        public void OnExit()
        {
            Console.WriteLine("Exit");
        }
    }
}
