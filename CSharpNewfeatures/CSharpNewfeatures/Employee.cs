namespace CSharpNewfeatures
{
    public record Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; init; }

        public string State { get; set; }
    }

   public abstract record Order(int id, string orderDetails)
    {
        protected abstract string GetData(int value);
    }

    public record XyzOrder(int id, string orderDetails, int price) : Order(id, orderDetails)
    {
        protected override string GetData(int value)
        {
            return $"value entered for XyzOrder is:{value}";
        }
    }

    public record AbcOrder(int id, string orderDetails, int price) : Order(id, orderDetails)
    {
        protected override string GetData(int value)
        {
            return $"value entered for AbcOrder is:{value}";
        }
    }
}
