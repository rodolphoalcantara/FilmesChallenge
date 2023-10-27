using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FilmesChallenge.Domain.Entities
{
    public class VideoEntity : BaseEntity
    {
        [Required]
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [Required]
        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

        [Required]
        [JsonPropertyName("url")]
        public string URL { get; set; }
    }
}
