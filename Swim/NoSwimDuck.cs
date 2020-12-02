using PatternDuck.Interface;

namespace PatternDuck.Swim
{ 
    class NoSwimDuck : ISwimBehavior
    {
        public string Swimming => "Не умею плавать";
    }
}
