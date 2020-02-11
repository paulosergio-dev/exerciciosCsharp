namespace exercicio_217
{
    internal class Product
    {
        private string name;
        private double price;

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public object Price { get; internal set; }
    }
}