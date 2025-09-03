namespace Product
{    
   public partial class product {
        public string name { set; get; }
        public decimal price { set; get; }

        public string GetInfo()
        {
            return $"Gia san pham {name} la {price} : {description}";
        }
    }
}
