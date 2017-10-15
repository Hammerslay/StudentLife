using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLife.Model
{
    class Organization
    {
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
    }
}
