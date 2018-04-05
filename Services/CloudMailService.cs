using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace City3.API.Services
{
    public class CloudMailService : IMailService
    {
        private String _mailTo = "admin@me.de";
        private String _mailFrom = "user@me.de";

        public void Send(String subject, String message)
        {
            Debug.WriteLine($"Mail from {_mailFrom} to {_mailTo}, with LocalMailService.");
            Debug.WriteLine($"Subject: {subject}");
            Debug.WriteLine($"Message: {message}");
        }

    }

}
