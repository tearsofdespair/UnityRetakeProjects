namespace Decorator
{
    public abstract class HotDogDecorator : HotDog
    {
        protected HotDog HotDog;

        public HotDogDecorator(HotDog hotDog)
        {
            HotDog = hotDog;
        }
    }
}