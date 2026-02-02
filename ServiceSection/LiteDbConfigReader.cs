using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace ApiUrlBuilder.ServiceSection;

internal class LiteDbConfigReader
{
    public string Ambiente { get; init; } = string.Empty; //"BancoDeDadosConfigurados": "Embiente"
    public int PortaApi { get; init; }
    public string TokenApi { get; init; } = string.Empty;
    public bool IsValid() =>
        !string.IsNullOrWhiteSpace(Ambiente) &&
        PortaApi > 0 &&
        !string.IsNullOrWhiteSpace(TokenApi);
}
