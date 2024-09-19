public interface IControleDeAssinaturasRepository
{
    Task<IEnumerable<ControleDeAssinaturasModel>> GetAllAsync();
    Task<ControleDeAssinaturasModel> GetByIdAsync(Guid id);
    Task<ControleDeAssinaturasModel> CreateAsync(ControleDeAssinaturasModel controleDeAssinaturas);
    Task UpdateAsync(ControleDeAssinaturasModel controleDeAssinaturas);
    Task DeleteAsync(Guid id);
}