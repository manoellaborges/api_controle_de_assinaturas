
using Microsoft.EntityFrameworkCore;

public class ControleDeAssinaturasRepository : IControleDeAssinaturasRepository
{
    private readonly AppDbContext _context;

    public ControleDeAssinaturasRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<ControleDeAssinaturasModel> CreateAsync(ControleDeAssinaturasModel controleDeAssinaturas)
    {
        await _context.ControleDeAssinaturas.AddAsync(controleDeAssinaturas);
        await _context.SaveChangesAsync();
        return controleDeAssinaturas;
    }

    public async Task DeleteAsync(Guid id)
    {
        ControleDeAssinaturasModel? clienteId = await _context.ControleDeAssinaturas.FindAsync(id);
        if (clienteId != null)
        {
            _context.ControleDeAssinaturas.Remove(clienteId);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<ControleDeAssinaturasModel>> GetAllAsync()
    {
        return await _context.ControleDeAssinaturas.ToListAsync();
    }

    public async Task<ControleDeAssinaturasModel> GetByIdAsync(Guid id)
    {
        return await _context.ControleDeAssinaturas.FindAsync(id);
    }

    public async Task UpdateAsync(ControleDeAssinaturasModel controleDeAssinaturas)
    {
        _context.ControleDeAssinaturas.Update(controleDeAssinaturas);
        await _context.SaveChangesAsync();
    }
}