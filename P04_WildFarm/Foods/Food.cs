namespace WildFarm.Foods
{
    public abstract class Food
    {
        public Food(string type, int quantity)
        {
            this.Type = type;
            this.Quantity = quantity;
        }
        public string Type { get; set; }
        public int Quantity { get; set; }
    }
}
