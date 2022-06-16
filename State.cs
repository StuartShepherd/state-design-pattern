namespace StateDesignPattern
{
    public abstract class State
    {
        protected Context _context;

        public void SetContext(Context context) =>
            _context = context;

        public abstract void HandlePrevious();

        public abstract void HandleNext();
    }
}