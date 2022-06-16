using System;

namespace StateDesignPattern
{
    public class ConcreteStateGamma : State
    {
        public override void HandlePrevious()
        {
            _context.TransitionTo(new ConcreteStateBeta());
        }

        public override void HandleNext()
        {
            Console.WriteLine();
            Console.WriteLine("ConcreteStateGamma is last state.");
            Console.WriteLine();
        }
    }
}