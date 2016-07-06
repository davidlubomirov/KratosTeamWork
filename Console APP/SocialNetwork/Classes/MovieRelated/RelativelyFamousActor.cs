using SocialNetwork.Abstract;

namespace SocialNetwork.Classes
{
    public class RelativelyFamousActor:NotSoFamousActor
        //just one OScar
    {
        private bool hasOscar;

        public RelativelyFamousActor() { }

        public RelativelyFamousActor(bool hasOscar=true)
        {
            this.HasOscar = hasOscar;
        }

        public bool HasOscar
        {
            get { return hasOscar; }
            set { hasOscar = value; }
        }
    }
}