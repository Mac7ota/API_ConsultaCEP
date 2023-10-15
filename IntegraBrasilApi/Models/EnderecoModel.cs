using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Models
{
    public class EnderecoModel
    {
        /// <summary>
        /// O uso do JsonProperty especificando Name nele e quando a propriedade nao vai ter o mesmo nome que o json exemplo     City e  Cidade não faz diferença caso o nome seja o mesmo
        /// </summary>
       
        [JsonPropertyName("cep")]
        public string? Cep { get; set; }

        [JsonPropertyName("state")]
        public string? Estado { get; set; }

        [JsonPropertyName("city")]
        public string? Cidade { get; set; }

        [JsonPropertyName("neighborhood")]
        public string? Regiao { get; set; }

        [JsonPropertyName("street")]
        public string? Rua { get; set; }

        [JsonPropertyName("service")]
        public string? Servico { get; set; }
    }
}
