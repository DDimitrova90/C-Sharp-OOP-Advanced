namespace _04_Telephony
{
    using System.Linq;

    public class Smartphone : IBrowseable, ICallable
    {
        public string BrowseWeb(string siteUrl)
        {
            if (!SiteIsValid(siteUrl))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {siteUrl}!";
        }

        private bool SiteIsValid(string siteUrl)
        {
            if (siteUrl.Any(c => char.IsDigit(c)))
            {
                return false;
            }

            return true;
        }

        public string Call(string phoneNumber)
        {
            if (!NumberIsValid(phoneNumber))
            {
                return "Invalid number!";
            }

            return $"Calling... {phoneNumber}";
        }

        private bool NumberIsValid(string phoneNumber)
        {
            if (phoneNumber.All(c => char.IsDigit(c)))
            {
                return true;
            }

            return false;
        }
    }
}
