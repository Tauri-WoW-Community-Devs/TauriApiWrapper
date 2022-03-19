using System;

namespace TauriApiWrapper.Attributes
{
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = true)]
    internal class NameAttribute : Attribute
    {
        internal string Name { get; private set; }

        internal NameAttribute(string name)
        {
            Name = name;
        }
    }
}