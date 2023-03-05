using System;

namespace exercice3.classes
{
    public class Ouvrier : Employee
    {
        private int _salary = 2500;
        private DateTime _entersIn;
        
        public DateTime EntersIn
        {
            get { return _entersIn; }
            set { _entersIn = value; }
        }
        
        public Ouvrier(string fnname, string lname, DateTime bday, DateTime enterIn) : base(fnname, lname, bday)
        {
            EntersIn = enterIn;
            setSalary();
        }

        public void setSalary()
        {
            if ((_age * 100) > (2 * _salary))
            {
                _salary *= 2;
            }
            else
            {
                _salary = 100 * _age;
            }
        }

        public override string ToString()
        { 
            return $"Employé : {_matricule} ; Job : Ouvrier ; {_first_name} {_last_name} ; {_age} ans";
        }
    }
}