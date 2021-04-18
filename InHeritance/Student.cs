using System;
using System.Collections.Generic;

using System.Text;

namespace InHeritance
{
    public class Student
    {
        //[Required]
        public int Id { get; set; }
        [Min18YearsCustomValidation]
        public DateTime DateofBirth { get; set; }
    }
}
