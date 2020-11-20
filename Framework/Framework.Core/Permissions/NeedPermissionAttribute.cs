using System;

namespace Framework.Core.Permissions
{
    [AttributeUsage(AttributeTargets.Method)]
    public class NeedPermissionAttribute:Attribute
    {
        public string Permission { get; private set; }

        public NeedPermissionAttribute(object permission)
        {
            Permission =permission.ToString();
        }

    }
}
