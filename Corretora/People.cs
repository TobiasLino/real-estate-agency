using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace People
{
    // TODO (Tobias): Adicionar sobrecarga de operações de equals.
    namespace Contact
    {
        class Phone
        {
            private string number;
            public string Number
            {
                get => number;
                set => number = verify(value);
            }

            public Phone()
            {
                this.number = "";
            }
            public Phone(string number)
            {
                this.number = verify(number);
            }
            private string verify(string n)
            {
                if (Regex.IsMatch(n, @"^\d{9}$"))
                    return n;
                return "";
            }
        }
        class Email
        {
            private string name;
            private string domain;

            public Email()
            {
                this.name = "";
                this.domain = "";
            }
            public Email(string email)
            {
                setEmail(email);
            }

            public string getEmail()
            {
                return name + '@' + domain;
            }
            public void setEmail(string email)
            {
                string[] buff = verify(email);
                this.name = buff[0];
                this.domain = buff[1];
            }
            private string[] verify(string email)
            {
                string buff = "";
                int i = 0, j = email.Length;
                while (i < j)
                {
                    char s = email[i];
                    if (s == '@') break;

                    buff += s;
                    ++i;
                }
                string[] n = new string[2];
                n[0] = buff; n[1] = email.Substring(i + 1);
                return n;
            }
        }
    }

    class Address
    {
        public Address()
        {
            
        }
    }
    
    class PeopleBase
    {
        private List<string> names;
        private List<string> genders;
        private string cpfCnpj;
        private string peopleType;
        private DateTime birth;
        private List<Contact.Phone> phones;
        private List<Contact.Email> emails;
        private List<Address> address;

        public PeopleBase()
        {
            InitPeople();
            InitContact();
            InitAddress();
        }
        private void InitPeople()
        {
            names = new List<string>();
            names.Add("");
            genders = new List<string>();
            genders.Add("");
            peopleType = "fisical";
            cpfCnpj = "";
            birth = new DateTime();
        }
        private void InitContact()
        {
            phones = new List<Contact.Phone>();
            phones.Add(new Contact.Phone());
            emails = new List<Contact.Email>();
            emails.Add(new Contact.Email());
        }
        private void InitAddress()
        {
            address = new List<Address>();
            address.Add(new Address());
        }

        public void Print()
        {
            Console.WriteLine("Imprimindo de peopleBase");
        }
    }
}
