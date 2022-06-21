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
        public bool AllowMoreThanOneActivePush { get; set; }

        public virtual Queam Queam { get; set; }
        public virtual List<QueQueamQueser> QueQueamQuesers { get; set; }

        public Que()
        {
        }

        public Que(Guid id, string title, DateTime creationTimeUtc, bool allowMoreThanOneActivePush, Queam queam, List<QueQueamQueser> queQueamQuesers)
        {
            Id = id;
            Title = title;
            CreationTimeUtc = creationTimeUtc;
            AllowMoreThanOneActivePush = allowMoreThanOneActivePush;
            Queam = queam;
            QueQueamQuesers = queQueamQuesers;
        }

        public Que(Queam queam, string title, bool allowMoreThanOnePush = false)
            : this(Guid.NewGuid(), title, DateTime.UtcNow, allowMoreThanOnePush, queam, new List<QueQueamQueser>())
        {
        }

        public QueQueamQueser Push(Queser queser, string comment)
        {
            QueamQueser queamQueser = Queam.FindMember(queser) ?? throw QuewerException.IsNotQueamMember();

            if (!AllowMoreThanOneActivePush && QueQueamQuesers.Any(qqq => qqq.QueamQueser.Id == queamQueser.Id))
                throw QuewerException.MemberAlreadyInQue();

            var queQueamQueser = QueQueamQueser.Create(this, queamQueser, comment);
            QueQueamQuesers.Add(queQueamQueser);
            return queQueamQueser;
        }
    }
}