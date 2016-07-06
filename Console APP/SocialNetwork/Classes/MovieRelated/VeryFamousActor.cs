using SocialNetwork.Abstract;

namespace SocialNetwork.Classes
{
    public class VeryFamousActor:RelativelyFamousActor
        //more than one Oscar
    {
        private uint numberOfOScars;
        
        public VeryFamousActor() { }
        public VeryFamousActor(uint numberOfOScars)
        {
            this.NumberOfOScars = numberOfOScars;
        }

        public uint NumberOfOScars
        {
            get { return numberOfOScars; }
            set { numberOfOScars = value; }
        }
    }
}