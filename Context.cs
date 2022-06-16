using System;

namespace StateDesignPattern
{
    public class Context
    {
        private State _state = null;

        public Context(State state) =>
            TransitionTo(state);

        public void TransitionTo(State state)
        {
            _state = state;
            _state.SetContext(this);

            Console.WriteLine($"Transitioned to {state.GetType().Name}.");
        }

        public void Previous() =>
            _state.HandlePrevious();

        public void Next() =>
            _state.HandleNext();
    }
}