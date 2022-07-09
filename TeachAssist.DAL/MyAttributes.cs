using System;

namespace TeachAssist.DAL
{
    public class MyIgnoreAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = true)]
    public class MyDefaultAttribute : Attribute
    {
        public MyDefaultAttribute(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public class MyMappingAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
