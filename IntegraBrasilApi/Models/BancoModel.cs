using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Models
{
    public class BancoModel
    {
        /// <summary>
        /// O uso do JsonProperty especificando Name nele e quando a propriedade nao vai ter o mesmo nome que o json exemplo     City e  Cidade não faz diferença caso o nome seja o mesmo
        /// </summary>
        
        [JsonPropertyName("ispb")]
        public string? Ispb { get; set; }

        [JsonPropertyName("name")]
        public string? NomeAbreviado { get; set; }

        [JsonPropertyName("code")]
        public int? Codigo { get; set; }

        [JsonPropertyName("fullName")]
        public string? NomeCompleto { get; set; }


    }
}
