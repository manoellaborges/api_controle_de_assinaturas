public interface IControleDeAssinaturasServices
{
    Task<IEnumerable<ControleDeAssinaturasModel>> GetAllControleDeAssinaturasAsync();
    Task<ControleDeAssinaturasModel> GetControleDeAssinaturasByIdAsync(Guid id);
    Task<ControleDeAssinaturasModel> CreateControleDeAssinaturasAsync(ControleDeAssinaturasModel controleDeAssinaturas);
    Task UpdateControleDeAssinaturasAsync(ControleDeAssinaturasModel controleDeAssinaturas);
    Task DeleteControleDeAssinaturasAsync(Guid id);
}