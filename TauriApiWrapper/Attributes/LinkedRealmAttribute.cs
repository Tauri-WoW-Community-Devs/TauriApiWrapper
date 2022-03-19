using System;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Attributes
{
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = true)]
    internal sealed class LinkedRealmAttribute : Attribute
    {
        public LinkedRealmAttribute(Realm masterRealm)
        {
            MasterRealm = masterRealm;
        }

        public Realm MasterRealm { get; }
    }
}