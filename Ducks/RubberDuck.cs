using PatternDuck.Quacking;
using PatternDuck.Fly;
using PatternDuck.Swim;

namespace PatternDuck.Ducks
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();
            //swimBehavior = new SwimDuck();
        }
        public override object Display => "Я резиновая утка";
    }
}
