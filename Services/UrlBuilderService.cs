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
    public string BuildUrl(ApiProcesso processo, ApiConfig config)
    {
        string baseUrl = MontarBaseUrl(config);
        string UrlComParametros = MontarUrlComParametros(baseUrl, config);

        return UrlComParametros;
    }

    private string MontarBaseUrl(ApiConfig config) // Refazer com dicionário para implementar todas os endpoints
    {
        string versao;
        string endpoint;

        switch (config.Processo)
        {
            case ApiProcesso.ConsultarNotas:
                versao = "v2";
                endpoint = "invent/docs/consultar";
                break;
            case ApiProcesso.ConsultarPdf:
                versao = "v2";
                endpoint = "invent/docs/consultar/pdf";
                break;
            case ApiProcesso.ConsultarXml:
                versao = "v2";
                endpoint = "invent/docs/consultar/xml";
                break;
            default:
                throw new Exception("A consulta escolhida não é suportada.");
        }
        return $"http://localhost:{config.Porta}/api/{versao}/{config.Ambiente}/{endpoint}";
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

        if (!parametros.Any())//usar count ?!
            return baseUrl;

        //if(parametros is {Count:>0}) // Syntactic Sugar

        var queryString = string.Join("&", parametros.Select(p => $"{p.Key}={Uri.EscapeDataString(p.Value)}"));

        return $"{baseUrl}?{queryString}";
    }
}
