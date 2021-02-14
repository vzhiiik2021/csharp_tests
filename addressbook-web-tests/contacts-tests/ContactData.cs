﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contacts_tests
{
    class ContactData
    {        
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        
        //обозначить необязательное поле (в конструкоторе не надо посылать)
        public string Middlename { get; set; } = ""; 
        public string Nickname { get; set; } = "";
        public string Title { get; set; } = "";
        public string Company { get; set; } = "";
        public string Address { get; set; } = "";
        public string Homephone { get; set; } = "";
        public string Mobile { get; set; } = "";
        public string Workphone { get; set; } = "";
        public string Fax { get; set; } = "";
        public string Email { get; set; } = "";
        public string Email2 { get; set; } = "";
        public string Email3 { get; set; } = "";
        public string Homepage { get; set; } = "";
        public string Bday { get; set; } = "";
        public string Bmonth { get; set; } = "";
        public string Byear { get; set; } = "";
        public string Aday { get; set; } = "";
        public string Amonth { get; set; } = "";
        public string Ayear { get; set; } = "";
        public string Address2 { get; set; } = "";
        public string Phone2 { get; set; } = "";
        public string Notes { get; set; } = "";



        public ContactData(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }        
    }    
}
