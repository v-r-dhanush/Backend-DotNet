using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    internal class employee : company
    {
        private int _eid;
        private string _ename; //Writeonly
        private int _yob;
        private double _salary;
        private int _age; //Readonly

        public int eid
        {
            get { return _eid; }
            set { _eid = value; }
        }

        public string ename
        {
            get { return _ename; }
            set { _ename = value; }
        }

        public int yob
        {
            set
            {
                _yob = value;
                _age = 2024 - _yob;
                if (_age < 18)
                {
                    Console.WriteLine("you are not allowed to Registered");
                }
                else
                {
                    _age = 2024 - _yob;
                }
            }
        }

        public int age
        {
            get { return _age; }
        }

        public double salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public employee(int id,string name) : base(id,name)
        {

        }

        public string displayEmpDetails()
        {
            base.displayCompanyDetails();
            return _ename + " is having a age of "+ _age + " with a salary of " + _salary;
        }
    }
}
