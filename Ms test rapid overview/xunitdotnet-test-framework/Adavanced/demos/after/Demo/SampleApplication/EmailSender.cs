namespace SampleApplication
{
    public class PromoEmailSender
    {
        private readonly IEmailServer _server;

        public PromoEmailSender(IEmailServer server)
        {
            _server = server;
        }

        public void Send(string message)
        {
            _server.Submit(message);
        }
    }
}
