using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    public class Person
    {
        public string Name;
        public string Photo;
        public string Education;
        public string Exp;
        public int Age;
        public DateTime BirthDate;
        public IdInfo IdInfo;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }
        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = String.Copy(Name);
            clone.Education = String.Copy(Education);
            return clone;
        }
    }
}
