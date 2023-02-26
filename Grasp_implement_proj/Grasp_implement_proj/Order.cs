namespace Grasp_implement_proj
{
    public class Order
    {
        public int Id { get; set; } = 0;

        public int Amount { get => _orders.Sum(); }

        public int[] _orders = new int[] { 10, 20, 30, 100 };
    }
}
