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

        public virtual List<QueamQueser> QueamQuesers { get; private set; }
        public virtual List<Que> Ques { get; private set; }

        public Queam(String name, Queser creator) : this()
        {
            Id = Guid.NewGuid();
            Name = name;
            QueamQuesers = new List<QueamQueser> { QueamQueser.CreateCreator(this, creator) };
            Ques = new List<Que>();
        }

        protected Queam()
        {
        }

        public static Queam Create(String name, Queser creator)
        {
            return new Queam(name, creator);
        }

        public Que CreateNewQue(Queser queser, string title, bool allowMoreThanOnePush = false)
        {
            QueamQueser queamQueser = FindMember(queser) ?? throw QuewerException.IsNotQueamMember();
            if (queamQueser.Role != QueamQueserRole.Admin && queamQueser.Role != QueamQueserRole.Creator)
                throw new QuewerException("Not enough permission");

            var que = new Que(this, title, allowMoreThanOnePush);

            Ques.Add(que);
            return que;
        }

        public QueamQueser FindMember(Queser queser) => QueamQuesers.Find(qq => qq.Queser.Id == queser.Id);
    }
}