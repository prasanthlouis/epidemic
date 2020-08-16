using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epidemic.Models
{
    public abstract class Role
    {
        public string Description { get; }
        public abstract void Ability();
    }
}
