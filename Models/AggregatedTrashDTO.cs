using Api.Models.Enums.DTO;

namespace Api.Models
{

    public class AggregatedTrashDto
    {
        public int Id { get; set; }
        public LitterType? Type { get; set; }
        public DateTime Date { get; set; }
        public double Confidence { get; set; }
        public string? Weather { get; set; }
        public int Temperature { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }

}