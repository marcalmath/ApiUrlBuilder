using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUrlBuilder.Models;

public class ApiConfig
{
    public string Ambiente { get; set; } = string.Empty;
    public int Porta { get; set; }
    public int? Modelo { get; set; } //Mudar em tela NFe (55) e NFC-e (65) para os parâmetros
    public int? BatchId { get; set; }
    public string? Chave { get; set; } = string.Empty;
    public ApiProcesso Processo { get; set; }
}

public enum ModeloFiscal
{
    NFe = 55,
    NFCe = 65
}