using KPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.Web.Infrastructure.Security
{
    public class UserToken
    {
        public UserToken(string userName, string ipAddress, int timeOut = 15)
        {
            this.CreatedDate = DateTime.Now;
            this.TimeOut = timeOut;
            this.UserName = userName;
            this.IpAddress = ipAddress;
            this.Token = Encryptor.Encrypt(string.Format("{0}:{1}-{2}-{3}", UserName, DateSticks, CreatedDate.ToLongDateString(), IpAddress));
        }

        public string Token { get; set; }

        public string IpAddress { get; set; }
        public string DateSticks { 
            get {
                return CreatedDate == DateTime.MinValue ? DateTime.Now.Ticks.ToString() : CreatedDate.Ticks.ToString();
            } 
        }

        public DateTime CreatedDate { get; set; }

        public int? TimeOut { get; set; }

        public string UserName { get; set; }

        public bool HasExpired
        {
            get
            {
                return DateTime.Now.Subtract(this.CreatedDate).Minutes > (this.TimeOut);
            }
        }
    }
}
