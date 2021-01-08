using System;
using System.Collections.Generic;
using Quewer.Core.Enums;
using Quewer.Core.Tools;

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
            QueamQuesers = new List<QueamQueser> { QueamQueser.CreateCreator(this, creator) };
            Ques = new List<Que>();
        }

        public static Queam Create(String name, Queser creator)
        {
            return new Queam(name, creator);
        }

        public Que CreateNewQue(Queser queser, string title)
        {
            QueamQueser queamQueser = FindMember(queser) ?? throw QuewerException.IsNotQuemMember();
            if (queamQueser.Role != QueamQueserRole.Admin && queamQueser.Role != QueamQueserRole.Creator)
                throw new QuewerException("Not enough permission");

            var que = Que.Create(this, title);

            Ques.Add(que);
            return que;
        }

        public QueamQueser FindMember(Queser queser) => QueamQuesers.Find(qq => qq.Id == queser.Id);
    }
}