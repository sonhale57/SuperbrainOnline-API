using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperbrainOnline_API.Models
{
    public class UserData
    {
    }
    public class Login
    {
        public string LoginProvider { get; set;}
        public string ProviderKey { get; set;}
        public string UserName { get; set;}
        public string Password { get; set;}
    }
    public class Register
    {
        public string RegisterProvider { get; set; }
        public string ProviderKey { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PHHS_bietqua { get; set; }
        public string PHHS_bietappqua { get; set; }
        public bool? Tunghoc { get; set; }
        public bool? IsUseful { get; set; }

    }
    public class Response
    {
        public string Result { get; set;}
        public string Status { get; set; }
        public string Message { get; set; }
    }
}