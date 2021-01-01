using System;
using System.Collections.Generic;

namespace Quewer.Core.Models
{
    public class Que
    {
        public Guid Id { get; set; }
        public Queam Queam { get; set; }
        public string Title { get; set; }
        public DateTime CreationTimeUtc { get; set; }

        public List<QueQueamQueser> QueQueamQuesers { get; set; }

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
    }
}