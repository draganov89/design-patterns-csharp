namespace design_patterns_csharp.Strategy.Components
{
    public class Animal 
    {
        private IMovingBehaviour _movingBehaviour;
        private IEatingBehaviour _eatingBehaviour;

        public Animal(IMovingBehaviour movingBehaviour,
                            IEatingBehaviour eatingBehaviour)
        {
            _movingBehaviour = movingBehaviour;
            _eatingBehaviour = eatingBehaviour;
        }

        public void Move()
        {
            _movingBehaviour.Move();
        }
    }
}