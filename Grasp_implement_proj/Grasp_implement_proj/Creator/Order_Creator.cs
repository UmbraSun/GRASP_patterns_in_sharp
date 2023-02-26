using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Grasp_implement_proj.Creator
{
    //Creator или Создатель — суть ответственности такого объекта в том, что он создает другие объекты. Сразу напрашивается аналогия с абстрактной фабрикой. 
    //Creator - the essence of the responsibility of such an object is that it creates other objects. An analogy with an abstract factory immediately suggests itself.
    public class Order_Creator
    {
        private List<Order> Orders = new List<Order>();

        public void AddOrder(List<Order> orders)
        {
            Orders.AddRange(orders); // not factory
        }

        public void CreateOrder(int OrderId)
        {
            Orders.Add(new Order { Id = OrderId }); // creator _ создатель
        }
    }
    //But there are a number of things that must be done when we make an object the responsibility of the creator.
    //Но есть ряд моментов, которые должны выполняться, когда мы наделяем объект ответственностью создателя:

    //1) Creator contains or aggregates created objects;                Создатель содержит или агрегирует создаваемые объекты; 
    //2) Creator uses created objects;                                  Создатель использует создаваемые объекты;      
    //3) The creator knows how to initialize the created object;        Создатель знает, как проинициализировать создаваемый объект;
    //4) Creator writes down created objects;                           Создатель записывает создаваемые объекты
    //5) Creator has initialization data for A;                         Создатель имеет данные инициализации для A
}
