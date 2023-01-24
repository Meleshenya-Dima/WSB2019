using WorldSkillsMart.Model;

namespace WorldSkillsMart.ViewModel
{
    static class StaticClientInformation
    {
        private static Client client;
        public static Client Client
        {
            get
            {
                return client;
            }
            set
            {
                client = value;
            }
        }
    }
}
