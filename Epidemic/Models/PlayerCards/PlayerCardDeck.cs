using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Epidemic.Models.PlayerCards
{
    public class PlayerCardDeck
    {
        private PlayerCards[] playerCards;
        private int cardsInDeck;

        public PlayerCardDeck(Epidemic[] EpidemicDeck, City[] CityDeck, Event[] EventDeck)
        {
            cardsInDeck = EpidemicDeck.Length + CityDeck.Length + EventDeck.Length;
            playerCards = new PlayerCards[cardsInDeck];
            Shuffle(CityDeck);
            Shuffle(EventDeck);
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
            
            return playerCards[--cardsInDeck];
        }
        
        public bool IsEmpty()
        {
            return cardsInDeck == 0;
        }
    }
}
