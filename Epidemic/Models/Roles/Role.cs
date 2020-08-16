using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Epidemic.Models
{
    public abstract class Role
    {
        public string Description { get; }
        public Color Color { get; }
        public abstract void Ability();
    }
}
