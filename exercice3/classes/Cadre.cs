using System;

namespace exercice3.classes
{
    public class Cadre : Employee
    {
        private short _indice;

        public Cadre(string fname, string lname, DateTime bday, short indice) : base(fname, lname, bday)
        {
            switch (indice)
            {
                case 1:
                    this._indice = 1;
                    break;
                case 2:
                    this._indice = 2;
                    break;
                case 3:
                    this._indice = 3;
                    break;       
                case 4:
                    this._indice = 4;
                    break;
                default:
                    this._indice = 1;
                    break;
            }
        }

        public int getSalary()
        {
            switch (_indice)
            {
                case 1:
                    return 13000;
                    break;
                case 2:
                    return 15000;
                    break;
                case 3:
                    return 17000;
                    break;       
                case 4:
                    return 20000;
                    break;
                default:
                    return 13000;
            }
        }

        public override string ToString()
        {
            return $"Employé : {_matricule} ; Job : Cadre ; {_first_name} {_last_name} ; {_age} ans ; Salaire : {getSalary()}";
        }
    }
}