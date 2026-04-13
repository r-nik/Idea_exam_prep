using System.Text.Json.Serialization;

namespace exam_prep_idea_center.Models
{
    internal class ApiResponseDTO
    {
        [JsonPropertyName("msg")]

        public string? Msg { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }
    }
}