using PatternDuck.Quacking;
using PatternDuck.Fly;
using PatternDuck.Swim;

namespace PatternDuck.Ducks
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
            swimBehavior = new SwimDuck();
        }
        public override object Display => "Я реальная утка";
    }
}
