using System;
using System.Collections.Generic;
using System.Linq;
using Quewer.Core.Tools;

namespace Quewer.Core.Models
{
    public class Que
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreationTimeUtc { get; set; }

        public virtual Queam Queam { get; set; }
        public virtual List<QueQueamQueser> QueQueamQuesers { get; set; }

        public static Que Create(Queam queam, string title)
        {
            return new Que
            {
                Id = Guid.NewGuid(),
                Queam = queam,
                Title = title,
                CreationTimeUtc = DateTime.UtcNow,
                QueQueamQuesers = new List<QueQueamQueser>()
            };
        }

        public QueQueamQueser Push(Queser queser, string comment)
        {
            QueamQueser queamQueser = Queam.FindMember(queser) ?? throw QuewerException.IsNotQuemMember();

            //TODO: Add options that allowed to register many time
            if (QueQueamQuesers.Any(qqq => qqq.QueamQueser.Id == queamQueser.Id))
                throw QuewerException.MemberAlreadyInQue();

            var queQueamQueser = QueQueamQueser.Create(this, queamQueser, comment);
            QueQueamQuesers.Add(queQueamQueser);
            return queQueamQueser;
        }
    }
}