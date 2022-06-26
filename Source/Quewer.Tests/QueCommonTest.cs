using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Quewer.Core.DataAccess;
using Quewer.Core.Models;
using Quewer.Core.Services;

namespace Quewer.Tests;

public class QueCommonTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void PushToQue_EnsureUserInQue()
    {
        var queser1 = new Queser(1, "Name1");
        var queam = new Queam("Team 1", queser1);
        Que que = queam.CreateNewQue(queser1, "Que");

        que.Push(queser1, null);

        Assert.IsTrue(que.QueQueamQuesers.Any(q => q.QueamQueser.Queser.Id == queser1.Id));
    }

    [Test]
    public void QueServiceTest()
    {
        QuewerDbContext quewerDbContext = TestDatabaseProvider.GetDatabaseContext();
        var quewerService = new QuewerService(quewerDbContext);

        quewerService.CreateQueser(1, "name");
        List<Queser> quesers = quewerService.ReadAll();

        Assert.AreEqual(1, quesers.Count);
    }
}
