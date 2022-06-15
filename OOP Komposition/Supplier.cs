using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Komposition
{
    public class Supplier
    {
        #region Fields
        private int id;
        private string name;
        private ContactInfo contactinfo;
        #endregion

        #region Constructs
        public Supplier(int id, string name, ContactInfo contactinfo)
        {
            Id = id;
            Name = name;
            ContactInfo = contactinfo;
        }
        #endregion

        #region Properties
        public int Id
        {
            get => id; set
            {
                id = value;
            }
        }
        public string Name
        {
            get => name; set
            {
                name = value;
            }
        }
        public ContactInfo ContactInfo
        {
            get => contactinfo; set
            {
                contactinfo = value;
            }
        }
        #endregion
    }
}
