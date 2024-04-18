using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace projetoSequorEmC_.Models
{
    public class Order
    {
        public string Orders { get; set; }
        public double Quantity { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string Image { get; set; }
        public double CycleTime { get; set; }
        public List<Material> Materials { get; set; }


        public Order(string order, double quantity, string productCode, string productDescription, string image, double cycleTime, List<Material> materials)
        {
            Orders = order;
            Quantity = quantity;
            ProductCode = productCode;
            ProductDescription = productDescription;
            Image = image;
            CycleTime = cycleTime;
            Materials = materials;

        }

    }

}



