using System;

namespace exercice3.classes
{
    public class Director : Employee
    {
        private float _perc;
        private float _salary;
        
        public Director(string fnname, string lname, DateTime bday, float ca, float perc) : base(fnname, lname, bday)
        {
            if (perc >= 100 || perc <= 100)
            {
                this._perc = perc;
                this._salary = dtmSalary(ca);
            }
            else
            {
                this._perc = 1;
                this._salary = dtmSalary(ca);
            }
        }

        private float dtmSalary(float ca)
        {
            return ca / this._perc;
        }

        public override string ToString()
        {
            return
                $"Employée {_matricule} ; Job : Directeur ; {_first_name} {_last_name} {_age} ans ; Salaire : {_salary} écus";
        }
    }
}