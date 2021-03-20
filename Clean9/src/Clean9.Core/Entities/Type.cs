using Clean9.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean9.Core.Entities
{
    public class Type : BaseEntity
    {
        public string TypeName { get; set; }

        public Type(string typename)
        {
            TypeName = typename;
        }

        public Type()
        {
            TypeName = "Anything";
        }
    }
}
