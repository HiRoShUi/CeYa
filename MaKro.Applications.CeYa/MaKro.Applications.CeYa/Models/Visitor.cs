using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaKro.Applications.CeYa.Client.Models
{
    public class Visitor
    {
        private Guid _id;
        private string _firstname;
        private string _lastname;
        private string _emailAdress;
        private string _company;
        private string _contact;
        private DateTime _createdOn;
        private Picture _picture;

        public Visitor() { }

        public Visitor(Guid aiId, string aiFirstname, string aiLastname, string aiEmailAdress, string aiCompany, string aiContact, DateTime aiCreationDate, Picture aiPicture)
        {
            _id = aiId;
            _firstname = aiFirstname;
            _lastname = aiLastname;
            _emailAdress = aiEmailAdress;
            _company = aiCompany;
            _contact = aiContact;
            _createdOn = aiCreationDate;
            _picture = aiPicture;
        }


        public Guid Id
        {
            get { return _id; }
        }

        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public string MailAdress
        {
            get { return _emailAdress; }
            set { _emailAdress = value; }
        }

        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }

        public string Contact
        {
            get { return _contact; }
            set { _contact = value; }
        }

        public DateTime CreatedOn
        {
            get { return _createdOn; }
            set { _createdOn = value; }
        }

        public Picture Picture
        {
            get { return _picture; }
            set { _picture = value; }
        }
    }
}
