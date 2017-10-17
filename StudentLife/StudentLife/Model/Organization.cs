using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLife.Model
{
    class Organization
    {
        public Organization()
        {

        }
        public Organization(int id, string password)
        {
            Id = id;
            Password = password;
        }
        public Organization(int id, string name, string adress, string phoneNumber, string email, string website, string orgDescription)
        {
            Id = id;
            Name = name;
            Adress = adress;
            PhoneNumber = phoneNumber;
            Email = email;
            Website = website;
            OrgDescription = orgDescription;
        }

        private int id;
        private string password;
        private string name;
        private string adress;
        private string phoneNumber;
        private string email;
        private string website;
        private string orgDescription;
        private List<Hap> haps;

        public string Name { get => name; set => name = value; }
        public string Adress { get => adress; set => adress = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Website { get => website; set => website = value; }
        public string OrgDescription { get => orgDescription; set => orgDescription = value; }
        public List<Hap> Haps { get => haps; set => haps = value; }
        public int Id { get => id; set => id = value; }
        public string Password { get => password; set => password = value; }
    }
}
