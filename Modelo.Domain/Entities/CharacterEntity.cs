using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public abstract class CharacterEntity : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Hair { get; set; }
        public string Eyes { get; set; }
        public string Details { get; set; }
        

    }
}
