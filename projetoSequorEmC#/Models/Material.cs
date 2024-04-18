namespace projetoSequorEmC_.Models
{
    public class Material
    {

        public string MaterialCode { get; set; }
        public string MaterialDescription { get; set; }

        public Material(string materialCode, string materialDescription)
        {
            MaterialCode = materialCode;
            MaterialDescription = materialDescription;
        }
    }
}
