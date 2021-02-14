using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    class GroupData
    {        
        public string Name { get; set; }
        
        //обозначить необязательное поле (в конструкоторе не надо посылать)
        public string Header { get; set; } = ""; 
        public string Footer { get; set; } = "";

        //конструктор с одним параметром
        public GroupData(string name)
        {
            Name = name;            
        }
        //тот же конструктор, но с несколькими параметрами
        public GroupData(string name, string header, string footer)
        {
            Name = name;
            Header = header;
            Footer = footer;
        }
    }    
}
