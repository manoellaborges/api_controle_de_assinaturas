using System;
using System.Text.Json.Serialization;

public class ControleDeAssinaturasModel
{
    [JsonIgnore]
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime DataCriacao { get; set; }
    public DateTime DataPagamento { get; set; }
    public string Status { get; set; }
    public string IdLinkPagamento { get; set; }
    public decimal Valor {  get; set; }
    public string IdCliente { get; set; }
    public string IdPagamento { get; set; }
    public string IdAssinatura { get; set; }
    public string NumeroFatura { get; set; }
    public string NomeCliente { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string Estado { get; set; }
    public string Cidade { get; set; }
}
