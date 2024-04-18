using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace projetoSequorEmC_.Models
{
    public class Production
    {
        [Required]
        [JsonPropertyName("order")]
        public string Order { get; set; }

        [Required]
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [Required]
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [Required]
        [JsonPropertyName("materialCode")]
        public string MaterialCode { get; set; }

        [Required]
        [JsonPropertyName("cycleTime")]
        public double CycleTime { get; set; }

        [Required]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        public Production(string order, string date, int quantity, string materialCode, double cycleTime, string email) 
        { 
        
            Order = order;
            Date = date;
            Quantity = quantity;
            MaterialCode = materialCode;
            CycleTime = cycleTime;
            Email = email;

        }
    }
}
