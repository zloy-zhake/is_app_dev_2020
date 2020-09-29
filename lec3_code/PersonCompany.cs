using System;

namespace lec3_code
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsBig { get; set; }
    }
}