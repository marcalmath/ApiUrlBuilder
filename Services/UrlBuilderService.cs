using ApiUrlBuilder.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUrlBuilder.Services;

public class UrlBuilderService
{
    private readonly Dictionary<ApiProcesso, ApiEndpoint> _endpoint =
        new Dictionary<ApiProcesso, ApiEndpoint>
        {
            { ApiProcesso.ConsultarNotas, new ApiEndpoint("invent/docs/consultar")},
            { ApiProcesso.ConsultarPdf, new ApiEndpoint("invent/docs/consultar/pdf")},
            { ApiProcesso.ConsultarXml, new ApiEndpoint("invent/docs/consultar/xml")},
            { ApiProcesso.RetransmitirNota, new ApiEndpoint("invent/docs/retransmitir")},
            { ApiProcesso.CancelarNota, new ApiEndpoint("invent/docs/cancelar")},
            { ApiProcesso.EntidadesEmissoras, new ApiEndpoint("invent/docs/consultar/entidadesemissoras")}
        };
        
    public string BuildUrl(ApiProcesso processo, ApiConfig config)
    {
        string baseUrl = MontarUrlBase(processo, config);
        string UrlComParametros = MontarUrlComParametros(baseUrl, config);

        return UrlComParametros;
    }

    private string MontarUrlBase(ApiProcesso processo, ApiConfig config)
    {
        if(!_endpoint.TryGetValue(processo, out var apiEndpoint))
        {
            throw new ArgumentException($"Endpoint não encontrado para o processo: {processo}");
        }

        return $"http://localhost:{config.Porta}/api/v3/{config.Ambiente}/{apiEndpoint.Endpoint}";
    }
    
    private string MontarUrlComParametros(string baseUrl, ApiConfig config)
    {
        var parametros = new Dictionary<string, string>();

        if (config.Modelo.HasValue)
            parametros.Add("modelo", config.Modelo.Value.ToString());

        if (config.BatchId.HasValue)
            parametros.Add("batchId", config.BatchId.Value.ToString());

        if (!string.IsNullOrWhiteSpace(config.Chave))
            parametros.Add("chave", config.Chave.ToString());

        if (!parametros.Any())
            return baseUrl;

        var queryString = string.Join("&", parametros.Select(p => $"{p.Key}={Uri.EscapeDataString(p.Value)}"));

        return $"{baseUrl}?{queryString}";
    }
}
