using System;

namespace Quewer.Core.Models
{
    public class Queser
    {
        public Guid Id { get; set; }
        public String Name { get; set; }

        private Queser(String name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public static Queser Create(String name)
        {
            return new Queser(name);
        }
    }
}