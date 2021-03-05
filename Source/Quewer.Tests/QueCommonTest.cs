using System.Linq;
using NUnit.Framework;
using Quewer.Core.Models;

namespace Quewer.Tests
{
    public class QueCommonTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var queser1 = Queser.Create("Name1");
            var queam = Queam.Create("Team 1", queser1);
            Que que = queam.CreateNewQue(queser1, "Que");

            que.Push(queser1, null);

            Assert.IsTrue(que.QueQueamQuesers.Any(q => q.QueamQueser.Queser.Id == queser1.Id));
        }
    }
}