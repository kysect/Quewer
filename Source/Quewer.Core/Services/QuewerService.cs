using System.Collections.Generic;
using System.Linq;
using Quewer.Core.DataAccess;
using Quewer.Core.Models;

namespace Quewer.Core.Services;

public class QuewerService
{
    private readonly QuewerDbContext _context;

    public QuewerService(QuewerDbContext context)
    {
        _context = context;
    }

    public Queser CreateQueser(long id, string name)
    {
        var queser = new Queser(id, name);
        _context.Quesers.Add(queser);
        _context.SaveChanges();

        return queser;
    }

    public List<Queser> ReadAll()
    {
        return _context.Quesers.ToList();
    }
}
