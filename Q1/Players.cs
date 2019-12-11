using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    //enum
    public enum Position
    {
        Goalkeeper,
        Defender,
        Midfielder,
        Forward
    }
    class Players
    {
        // Properies
        public string First_Name { get; set; }
        public string Surname { get; set; }
        public Position Preferred_Position { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        private int age;
        public int Age
        {
            get
            {
                age = Date_Of_Birth.Year - DateTime.Now.Year;
                return age;
            }
        }
        
        public Players(string firstname, string surname, Position preferredposition, DateTime dateofbirth)
        {
            firstname = First_Name;
            surname = Surname;
            preferredposition = Preferred_Position;
            dateofbirth = Date_Of_Birth;
        }
    }
}
