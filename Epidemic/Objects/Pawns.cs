using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Epidemic.Models;
using Epidemic.Models.PlayerCards;
using Microsoft.AspNetCore.Identity;

namespace Epidemic.Objects
{
    public class Pawns
    {
        public Color Color;
        public int MovementCounter { get; set; }
        public Cities City { get; set; }
        public Role Role { get; set; }
        public Pawns()
        {
            MovementCounter = 4;
        }
    }
}
