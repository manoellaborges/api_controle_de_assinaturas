
public class ControleDeAssinaturasServices : IControleDeAssinaturasServices
{
    private readonly IControleDeAssinaturasRepository _repository;

    public ControleDeAssinaturasServices(IControleDeAssinaturasRepository repository)
    {
        _repository = repository;
    }

    public async Task<ControleDeAssinaturasModel> CreateControleDeAssinaturasAsync(ControleDeAssinaturasModel controleDeAssinaturas)
    {
        return await _repository.CreateAsync(controleDeAssinaturas);
    }

    public async Task DeleteControleDeAssinaturasAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
    }

    public async Task<IEnumerable<ControleDeAssinaturasModel>> GetAllControleDeAssinaturasAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<ControleDeAssinaturasModel> GetControleDeAssinaturasByIdAsync(Guid id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task UpdateControleDeAssinaturasAsync(ControleDeAssinaturasModel controleDeAssinaturas)
    {
        await _repository.UpdateAsync(controleDeAssinaturas);
    }
}