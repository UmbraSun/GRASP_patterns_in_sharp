using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grasp_implement_proj.Protected_Variations
{
    /// <summary>
    /// Как архитекторы и программисты, мы должны быть готовы к постоянно меняющимся требованиям. 
    /// Это не является «nice to have» атрибутом - это «must-have» в любом приложении 
    /// и наша обязанность как программистов и архитекторов нашей системы это обеспечить. 
    /// </summary>
    public class Protected_Variations
    {
        // it is best to be tied to contracts, and not to start from some kind of implementation
        // (so there will be no problems with changing the logic if we do not change the contract itself)

        // лучше всего завязываться на контрактах, а не отталкиваться от какой-то реализации
        // (так не возникнет проблем с изменением логики, если мы не поменяем сам контракт)

        public IOrder _order { get; set; }

        public Protected_Variations(IOrder order) 
        {
            _order = order; // the logic is tied only to the contract, when changing the order type, the logic should not break here
        }
    }

    public interface IOrder
    {
        string Name { get; }
        string Id { get; }
    }
}
