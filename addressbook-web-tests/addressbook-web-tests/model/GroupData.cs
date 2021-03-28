using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class GroupData : IEquatable<GroupData>, IComparable<GroupData>
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

        //два метода дополняют друг друга
        public bool Equals(GroupData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }
            return Name == other.Name;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return "name = " + Name;
        }

        public int CompareTo(GroupData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }
            return Name.CompareTo(other.Name);    
        }
    }    
}
