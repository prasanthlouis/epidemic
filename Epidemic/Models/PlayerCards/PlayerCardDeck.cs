using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Epidemic.Models.PlayerCards
{
    public interface IPlayerCardDeck
    {
        PlayerCards Draw();
    }
    public class PlayerCardDeck : IPlayerCardDeck
    {
        public List<PlayerCards> PlayerCards { get; set; }
        private int cardsInDeck;

        public PlayerCardDeck(ICity city)
        {
            PlayerCards = new List<PlayerCards>();
            var cityDeck = city.BuildDeck();
            //Shuffle(CityDeck);
            //Shuffle(EventDeck);
            //Merge

        }
        
        private void Shuffle(PlayerCards[] deck) 
        {

        }
       
        public PlayerCards Draw()
        {
            if (IsEmpty())
            {
                //Custom Exception. End Game.
                Console.WriteLine("Players failed to stop the pandemic in time.");    
            }
            
            return PlayerCards[--cardsInDeck];
        }
        
        public bool IsEmpty()
        {
            return cardsInDeck == 0;
        }
    }
}
