using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices.Protocols;
using System.DirectoryServices.AccountManagement;
using System.Net;

// http://adlinq.codeplex.com/

namespace AD
{
    public class Helper
    {
        public string CurrentLDAPServerName = "";
        public int CurrentLDAPPortNumber = 389;
        public string CurrentUsername = "";
        public string CurrentPassword = "";
        private LdapConnection _CurrentConnection = null;

        public User GetUser(string sAMAccountName)
        {
            return GetUser(CurrentLDAPServerName, CurrentLDAPPortNumber, CurrentUsername, CurrentPassword, sAMAccountName);
        }

        public User GetUser(string Servername, string sAMAccountName)
        {
            return GetUser(Servername, CurrentLDAPPortNumber, CurrentUsername, CurrentPassword, sAMAccountName);
        }

        public User GetUser(string Servername, int PortNumber, string sAMAccountName)
        {
            return GetUser(Servername, PortNumber, CurrentUsername, CurrentPassword, sAMAccountName);
        }

        public User GetUser(string Servername, int PortNumber, string Username, string Password, string sAMAccountName)
        {
            User Result = null;
            
            CurrentLDAPServerName = Servername;
            CurrentLDAPPortNumber = PortNumber;
            CurrentUsername = Username;
            CurrentPassword = Password;


            string ConnectionString = "OU=Roles,DC=example,DC=com";

            ConnectionString = "LDAP://" + Servername + ":" + PortNumber + "/DC=Robinson,DC=int";

            

            return Result;
        }

        
    }
}
