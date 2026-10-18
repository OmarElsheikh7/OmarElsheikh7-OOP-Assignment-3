using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public class Student : IHasId
    {
        public int Id { get; set; }
        public string name { get; set; }
    }
}
