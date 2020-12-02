using PatternDuck.Quacking;
using PatternDuck.Fly;
using PatternDuck.Swim;

namespace PatternDuck.Ducks
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {    
            flyBehavior = new FlyRocketPowered();
            quackBehavior = new MuteQuack();
            swimBehavior = new SwimDuck();
        }
        public override object Display => "Я модель утки";
    }
}
