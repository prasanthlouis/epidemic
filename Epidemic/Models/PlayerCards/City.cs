using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Epidemic.Models.PlayerCards
{
    public interface ICity
    {
        List<City> BuildDeck();
    }
    public class City : PlayerCards, ICity
    {
        public Color Color { get; set; }
        public string Name { get; set; }

        public List<City> BuildDeck()
        {
            return new List<City>()
            {
                new City()
                {
                    Color = Color.Yellow,
                    Name = "Los Angeles"
                },
                new City()
                {
                    Color = Color.Red,
                    Name = "Chennai"
                }
            };
        }
    }
}
