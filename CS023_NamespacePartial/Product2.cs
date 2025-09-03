namespace Product
{
    public partial class product
    {
        public Manufactory manufactory { set; get; }

        public class Manufactory
        {
            // có thể khởi tạo lớp lồng nhau (nested class) => có thể gọi bên file Program
        }
        public string description { set; get; }
        public void Abc()
        {
            // ...
        }
    }
}
