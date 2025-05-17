using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Baby
    {
        public Baby() 
        {
            Console.WriteLine("Ingaaa");
            BirthDate = DateTime.Now;
            _name = "-";
            _surname = "-";
        }
        public Baby(string name, string surname)
        {
            Console.WriteLine("Ingaaa");
            BirthDate = DateTime.Now;
            _name = name;
            _surname = surname;
        }



        private string _name;
        private string _surname;
        private DateTime _birthDate;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
            }
        }
        public void DisplayBabyInfo()
        {
            Console.WriteLine("Bebek ismi: "+_name+" "+_surname+","+"Doğum tarihi: "+_birthDate);
        }
    }
}
