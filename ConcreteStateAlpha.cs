using System;

namespace StateDesignPattern
{
    public class ConcreteStateAlpha : State
    {
        public override void HandlePrevious()
        {
            Console.WriteLine();
            Console.WriteLine("ConcreteStateAlpha is first state.");
            Console.WriteLine();
        }

        public override void HandleNext()
        {
            _context.TransitionTo(new ConcreteStateBeta());
        }
    }
}