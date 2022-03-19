using System;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Attributes
{
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = true)]
    internal sealed class ExpansionAttribute : Attribute
    {
        public ExpansionAttribute(Expansion expansion)
        {
            Expansion = expansion;
        }

        public Expansion Expansion { get; }
    }
}