using PatternDuck.Quacking;
using PatternDuck.Fly;
using PatternDuck.Swim;

namespace PatternDuck.Ducks
{
    class IronDuck :Duck
    {
        public IronDuck()
        {
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyNoWay();
            swimBehavior = new NoSwimDuck();
        }
        public override object Display => "Я железная утка";
    }
}