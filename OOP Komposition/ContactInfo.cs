using System;
namespace OOP_Komposition
{
    public class ContactInfo
    {
        #region Fields
        private int id;
        private string mail;
        private string phonenumber;
        #endregion

        #region Contructors
        public ContactInfo(int id, string mail, string phonenumber)
        {
            Id = id;
            Mail = mail;
            Phonenumber = phonenumber;
        }
        #endregion

        #region Properties
        public int Id
        {
            get => id; 
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Invalid Input");
                }
                else
                id = value;
            }
        }
        public string Mail
        {
            get => mail; set
            {
                mail = value;
            }
        }
        public string Phonenumber
        {
            get => phonenumber; set
            {
                phonenumber = value;
            }
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Id: {id}, Mail: {mail}, Phone No: {phonenumber}".ToString();
        }
        #endregion
    }
}
