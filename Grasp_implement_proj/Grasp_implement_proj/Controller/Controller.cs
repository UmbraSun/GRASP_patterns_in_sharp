namespace Grasp_implement_proj.Controller
{
    /// <summary>
    /// Шаблон сontroller призван решить проблему разделения интерфейса и логики в интерактивном приложении. 
    /// Это не что иное, как хорошо известный контроллер из MVC парадигмы.
    /// 
    /// The controller pattern is designed to solve the problem of separating interface and logic in an interactive application. 
    /// This is nothing but a well-known controller from the MVC paradigm.
    /// </summary>
    public class Controller
    {
        public (int, int, int) SomeLogicFromView() => /*some logic and return result*/ (1, 2, 3);

        /// <summary>
        /// ours controller pattern here :O
        /// </summary>
        /// <param name="paramsFromView">parametrs from view</param>
        /// <returns></returns>
        public (int, int, int) ControllerLogic((int,int,int) paramsFromView) => /*some conroller logic such as validation*/ paramsFromView;

        /// <summary>
        /// some BLL logic such as working with data
        /// </summary>
        /// <param name="paramsFromController"></param>
        /// <returns></returns>
        public int ReturnResultFromBLL((int, int, int) paramsFromController)
            => paramsFromController.Item1 + paramsFromController.Item2 + paramsFromController.Item3;
    }
}
