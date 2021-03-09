using System;

namespace Quewer.Core.Models
{
    public class Queser
    {
        public Guid Id { get; set; }
        public String Name { get; set; }

        private Queser(String name) : this()
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        protected Queser() {}

        public static Queser Create(String name)
        {
            return new Queser(name);
        }
    }
}