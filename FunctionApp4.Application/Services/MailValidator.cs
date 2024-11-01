using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FunctionApp4.Application.Services
{
    public class MailValidator
    {
        public bool IsSpam(string emailAdress)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(emailAdress);
                return true;

            }
            catch (FormatException)
            {
                return false;
            }
        }


    }
}
