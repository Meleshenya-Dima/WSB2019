using WorldSkillsMart.Model;

namespace WorldSkillsMart.ViewModel
{
    static class StaticClientInformation
    {
        private static Client _client;
        public static Client Client
        {
            get
            {
                return _client;
            }
            set
            {
                _client = value;
            }
        }
    }
}
