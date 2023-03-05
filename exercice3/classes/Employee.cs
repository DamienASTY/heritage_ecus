using System;

namespace exercice3.classes
{
    public class Employee
    {
        protected string _matricule;
        protected string _first_name;
        protected string _last_name;
        private DateTime _birthday;
        protected int _age;


        public Employee(string fname, string lname, DateTime birthday)
        {
            this._matricule = defMatricule();
            this._first_name = fname;
            this._last_name = lname;
            this._birthday = birthday;
            defAge();
        }

        private string defMatricule()
        {
            Random random = new Random();
            int numero1 = random.Next(10000, 99999);
            int numero2 = random.Next(10000, 99999);
            int numero3 = random.Next(10000, 99999);
            char lettre1 = (char)random.Next('A', 'Z' + 1);
            char lettre2 = (char)random.Next('A', 'Z' + 1);
            char lettre3 = (char)random.Next('A', 'Z' + 1);
            return $"{numero1}-{numero2}-{numero3}-{lettre1}{lettre2}{lettre3}";;
        }

        private void defAge()
        {
            this._age = DateTime.Now.Year - _birthday.Year;
        }
    }
}