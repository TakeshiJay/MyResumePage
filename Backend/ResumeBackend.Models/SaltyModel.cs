namespace ResumeBackend.Models
{
    public class SaltyModel
    {
        public string salt { get; }
        public string message { get; }

        public SaltyModel(string saltString, string messageString)
        {
            salt = saltString;
            message = messageString;
        }
    }
}
