namespace SocialNetwork.Utils
{
    public class ValidateUsername
    {
        public bool ValidateUser(string username)
        {

            int validConditions = 0;

            foreach (char c in username)

            {

                if (c >= 'a' && c <= 'z')

                {

                    validConditions++;

                    break;

                }

            }

            foreach (char c in username)

            {

                if (c >= 'A' && c <= 'Z')

                {

                    validConditions++;

                    break;

                }

            }

            if (validConditions == 0) return false;
          
            if (validConditions == 1) return false;

            return true;

            //TODO: Implement try-catch exception 
        }

    }
}
