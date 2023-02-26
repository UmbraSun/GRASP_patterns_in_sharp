namespace Grasp_implement_proj.Information_Expert
{
    /// <summary>
    /// Responsibility should be assigned to the one who owns the maximum of the necessary information for execution - the information expert.
    /// Ответственность должна быть назначена тому, кто владеет максимумом необходимой информации для исполнения — информационному эксперту.
    /// </summary>
    public class Director_Information_Expert
    {

        //the Customer class contains references to all customer orders
        //класс Customer содержит ссылки на все заказы клиентов
        private readonly List<Order> orders = new List<Order>();

        //therefore it is logical to place here a method for calculating the total cost of orders
        //следовательно логично разместить тут метод для подсчета общей стоимости заказов
        public decimal GetTotalAmount(int id) 
            => this.orders.FirstOrDefault(x => x.Id == id)?.Amount ?? 
               throw new Exception($"Orders with this id: {id} doesn't exist");
    }
    //that is, general information must belong to one or more classes and be issued by these same classes
    //то есть, общая информация должна пренадлежать одному или нескольким классам и выдаваться этими самыми классами
}
