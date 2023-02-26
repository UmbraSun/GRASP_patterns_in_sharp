using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grasp_implement_proj.Polymorphism
{
    /// <summary>
    /// The principle of polymorphism is fundamental in OOP.
    /// 
    /// Полиморфизм позволяет реализовывать одноименные публичные методы, 
    /// позволяя различным классам выполнять различные действия при одном и том же вызове
    /// 
    /// Принцип полиморфизма является основополагающим в ООП.
    /// </summary>
    public class Polymorphism
    {
        Circle circle = new Circle();
        Square square = new Square();

        public void Draw()
        {
            circle.Render(); // polymorphism
            square.Render(); // polymorphism
        }
    }

    public abstract class AbsClass
    {
        public abstract void Render();
    }

    public class Circle : AbsClass
    {
        public override void Render()
        {
            // some logic
        }
    }

    public class Square : AbsClass
    {
        public override void Render()
        {
            // some logic
        }
    }
}
