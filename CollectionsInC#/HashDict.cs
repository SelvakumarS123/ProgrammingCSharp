using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsInC_
{
    public class HashDict
    {
        
    }
    public class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Score { get; set; }

        public Student(int id, String name, int score)
        {
            Id = id;
            Name = name;
            Score = score;
        }
    }
}
