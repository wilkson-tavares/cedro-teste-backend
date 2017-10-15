using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Configuration
{
    private ContextDB _context;

    public Configuration(ContextDB context)
    {
        _context = context;
    }

    public async Task SeedData()
    {
        if (!_context.restaurante.Any())
        {
            var user = new Restaurante()
            {
                ID = 1,
                Nome = "Teste"
            };

            _context.restaurante.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}
