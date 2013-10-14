using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace World_Email2
{
    class Email
    {
        public Email(string emailAdd)
        {
            if (checkEmail(emailAdd) == true)
            { }
                       
        }

        public Boolean checkEmail(string email)
        {
            Boolean emailValid = false;

            if (email.Contains('@') && email.Contains('.') && (!email.Contains(' ')))
            {
                emailValid = true;
            }
            
            return emailValid;
        }
    }

}
