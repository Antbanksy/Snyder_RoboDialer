using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snyder_RoboDialer
{
    public abstract class Phone
    {
        protected string phoneNumber;
        protected string companyName;

        public Phone(string phoneNumber, string companyName)
        {
            this.phoneNumber = phoneNumber;
            this.companyName = companyName;
        }

        public abstract string Dial();
    }

    public class HomePhone : Phone
    {
        public HomePhone(string phoneNumber, string companyName) : base(phoneNumber, companyName)
        {
        }

        public override string Dial()
        {
            string formattedNumber = FormatPhoneNumber(phoneNumber);
            return $"Dialing {companyName} using {formattedNumber}...";
        }

        private string FormatPhoneNumber(string phoneNumber)
        {
            return phoneNumber.Replace("(", "").Replace(")", "").Replace(" ", "");
        }
    }

    public class CellPhone : Phone
    {
        public CellPhone(string phoneNumber, string companyName) : base(phoneNumber, companyName)
        {
        }

        public override string Dial()
        {
            string formattedNumber = FormatPhoneNumber(phoneNumber);
            string dialingCode = "1+";
            return $"Dialing {companyName} using {dialingCode}{formattedNumber}...";
        }

        private string FormatPhoneNumber(string phoneNumber)
        {
            return phoneNumber.Replace("(", "").Replace(")", "").Replace(" ", "");
        }
    }


}
