using System;
using System.Collections.Generic;

namespace Quewer.Core.Models
{
    public class Que
    {
        public Guid Id { get; set; }
        public Queam Queam { get; set; }
        public List<QueQueamQueser> QueQueamQuesers { get; set; }
    }
}