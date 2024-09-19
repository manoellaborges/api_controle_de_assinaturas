using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ControleDeAssinaturasController : ControllerBase
{
    private readonly IControleDeAssinaturasServices _service;

    public ControleDeAssinaturasController(IControleDeAssinaturasServices service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        IEnumerable<ControleDeAssinaturasModel> controleDeAssinaturas = await _service.GetAllControleDeAssinaturasAsync();
        return Ok(controleDeAssinaturas);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        ControleDeAssinaturasModel controleDeAssinaturas = await _service.GetControleDeAssinaturasByIdAsync(id);
        if(controleDeAssinaturas  == null)
        {
            return NotFound();
        }
        return Ok(controleDeAssinaturas);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ControleDeAssinaturasModel controleDeAssinaturas)
    {
        ControleDeAssinaturasModel novo = await _service.CreateControleDeAssinaturasAsync(controleDeAssinaturas);
        return CreatedAtAction(nameof(GetById), new {id = novo.Id}, novo);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] ControleDeAssinaturasModel controleDeAssinaturas)
    {
        if(id != controleDeAssinaturas.Id)
        {
            return BadRequest();
        }
        await _service.UpdateControleDeAssinaturasAsync(controleDeAssinaturas);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _service.DeleteControleDeAssinaturasAsync(id);
        return NoContent();
    }
}