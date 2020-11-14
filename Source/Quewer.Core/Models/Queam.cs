using System;
using System.Collections.Generic;

namespace Quewer.Core.Models
{
    public class Queam
    {
        public Guid Id { get; private set; }
        public String Name { get; private set; }

        public List<QueamQueser> QueamQuesers { get; private set; }
        public List<Que> Ques { get; private set; }

        private Queam(String name, Queser creator)
        {
            Id = Guid.NewGuid();
            Name = name;
            QueamQuesers = new List<QueamQueser>() { QueamQueser.CreateCreator(this, creator) };
            Ques = new List<Que>();
        }

        public static Queam Create(String name, Queser creator)
        {
            return new Queam(name, creator);
        }
    }
}