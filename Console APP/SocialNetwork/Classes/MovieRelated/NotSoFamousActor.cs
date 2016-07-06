using SocialNetwork.Abstract;

namespace SocialNetwork.Classes
{
    public class NotSoFamousActor:Actor
        //NoOscars but other prizes
    {
        private uint numberOfPrizes;

        public NotSoFamousActor()
        {
            
        }

        public NotSoFamousActor(uint numberOfPrizes)
        {
            this.NumberOfPrizes = numberOfPrizes;
        }

        public uint NumberOfPrizes
        {
            get { return numberOfPrizes; }
            set { numberOfPrizes = value; }
        }
    }
}