using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epidemic.Models.PlayerCards
{
    public abstract class PlayerCards
    {
        public Cities City { get; set; }
        public Event Event { get; set; }
        public Epidemic Epidemic { get; set; }
    }
}
