namespace Vtitbid.ISP20.Pozdina.Obj4
{
    public class Price
    {
        public string Product { get; set; }
        public string Shop { get; set; }
        public string Cost { get; set; }

        public Price(string product, string shop, string cost)
        {
            Product = product;
            Shop = shop;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"Название товара: {Product}," +
                $" Название магазина: {Shop}," +
                $" Цена: {Cost}";
        }
    }
}