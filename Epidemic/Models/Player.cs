using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Epidemic.Models.PlayerCards;

namespace Epidemic.Models
{
    public class Player
    {
        public string Name { get; set; }
        public Role Role { get; set; }
        public Cities CurrentLocation { get; set; }
        public PlayerCards.PlayerCards Hand { get; set; }

        internal void AddCities()
        {
            
        }
    }
}
