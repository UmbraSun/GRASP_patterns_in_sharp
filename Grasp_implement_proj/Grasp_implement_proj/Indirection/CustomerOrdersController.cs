namespace Grasp_implement_proj.Indirection
{
    /// <summary>
    /// хорошей реализацией этого паттерна можно считать реализацию медиатора
    /// 
    /// a good implementation of this pattern can be considered the implementation of the mediator
    /// </summary>
    public class CustomerOrdersController // : Controller
    {
        /*
        
        private readonly IMediator _mediator;

        public CustomerOrdersController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        public async Task<IActionResult> AddCustomerOrder(
            [FromRoute] Guid customerId,
            [FromBody] CustomerOrderRequest request)
        {
            await _mediator.Send(new AddCustomerOrderCommand(customerId, request.Products));

            return Created(string.Empty, null);
        }

        */
    }

    // Обратите внимание. Посредник поддерживает "low coupling",
    // но снижает читабельность и понимание всей системы.
    // Вы не знаете, какой класс обрабатывает команду из определения Controller.
    // Это компромисс.
}
