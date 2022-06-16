namespace StateDesignPattern
{
    public class ConcreteStateBeta : State
    {
        public override void HandlePrevious()
        {
            _context.TransitionTo(new ConcreteStateAlpha());

        }

        public override void HandleNext()
        {
            _context.TransitionTo(new ConcreteStateGamma());
        }
    }
}