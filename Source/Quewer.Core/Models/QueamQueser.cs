using System;
using Quewer.Core.Enums;

namespace Quewer.Core.Models
{
    public class QueamQueser
    {
        public Guid Id { get; set; }
        public virtual Queam Queam { get; private set; }

        public virtual Queser Queser { get; private set; }

        public virtual QueamQueserRole Role { get; private set; }

        private QueamQueser(Queam queam, Queser queser, QueamQueserRole role) : this()
        {
            Id = Guid.NewGuid();
            Queam = queam;
            Queser = queser;
            Role = role;
        }

        protected QueamQueser()
        {
        }

        public static QueamQueser Create(Queam queam, Queser queser, QueamQueserRole role)
        {
            return new QueamQueser(queam, queser, role);
        }

        public static QueamQueser CreateCreator(Queam queam, Queser queser)
        {
            return new QueamQueser(queam, queser, QueamQueserRole.Creator);
        }
    }
}