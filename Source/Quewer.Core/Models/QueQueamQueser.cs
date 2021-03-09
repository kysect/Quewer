using System;

namespace Quewer.Core.Models
{
    public class QueQueamQueser
    {
        public Guid QueId { get; set; }
        public virtual Que Que { get; private set; }

        public Guid QueamQueserId { get; set; }
        public virtual QueamQueser QueamQueser { get; private set; }

        public DateTime PushTime { get; private set; }

        public String Comment { get; private set; }

        private QueQueamQueser(Que que, QueamQueser queamQueser, String comment) : this()
        {
            Que = que;
            QueamQueser = queamQueser;
            Comment = comment;
            PushTime = DateTime.UtcNow;
        }

        protected QueQueamQueser()
        {
        }

        public static QueQueamQueser Create(Que que, QueamQueser queamQueser, String comment)
        {
            return new QueQueamQueser(que, queamQueser, comment);
        }
    }
}