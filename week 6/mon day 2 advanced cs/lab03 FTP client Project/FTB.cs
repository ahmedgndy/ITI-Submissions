using lab03_FTP_client_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace lab03_FTP_client_Project
{
    enum Type
    {
        None = 0,
        ethernet = 1, 
        token= 2
    }
    internal class  NIC
    {
      public string manficature { get; }
      public string macAddress { get; }
       
      public Type type { get; }


        private static readonly NIC instance = new NIC(); 

        public static  NIC Instance
        {
            get
            {
                return instance;
            }
        }
        private  NIC()
        {
            manficature = "intel";
            macAddress = "00-14-22-01-23-45";
            type = Type.ethernet;

        }
    }
}
