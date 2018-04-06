using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace City3.API.Services
{
    public interface IMailService
    {
        void Send(String subject, String message);
    }
}
