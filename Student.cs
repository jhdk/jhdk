using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student  
    {
        private String _name;
        private int _age;
        public String Address { get; set; }
        public Student(String name, int age){
            this._name = name;
            this._age = age;

        }

        public Student(string name, int age, string address)
        {
            _name = name;
            _age = age;
            Address = address;
        }

        public string toString()
        {
            
        }
    }


}
