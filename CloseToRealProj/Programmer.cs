using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloseToRealProj
{
    enum TypeOfProgrammers
    {
        Backend,
        Frontend,
        Designer,
        Tester,
        TeamLead
    }
    internal class Programmer : Person
    {
        public Programmer(TypeOfProgrammers TProg)
        {
            typeOfProgrammers = TProg;
        }
        private TypeOfProgrammers typeOfProgrammers {  get; set; }
        public void SetInfo(string _firstname,string _lastname,int _age)
        {
            FirstName = _firstname;
            LastName = _lastname;
            Age = _age;
        }
        public void GetInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Age} yosh");
        }
    }
}
