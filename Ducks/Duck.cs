using PatternDuck.Interface;

namespace PatternDuck.Ducks
{
    abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;
        protected ISwimBehavior swimBehavior;

        public IQuackBehavior QuackBehavior { get => quackBehavior; set => quackBehavior = value; }

        public IFlyBehavior FlyBehavoir { get => flyBehavior; set => flyBehavior = value; }

        public ISwimBehavior SwimBehavoir { get => swimBehavior; set => swimBehavior = value; }

        public abstract object Display { get; }

        public object PerformFly => FlyBehavoir.Fly;

        public object PerformQuack => QuackBehavior.Quacking;

        public object PerformSwim => swimBehavior.Swimming;

    }
}
