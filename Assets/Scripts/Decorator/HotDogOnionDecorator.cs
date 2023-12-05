namespace Decorator
{
    public class HotDogOnionDecorator : HotDogDecorator
    {
        public HotDogOnionDecorator(HotDog hotDog) : base(hotDog)
        {
        }

        public override string GetName()
        {
            return HotDog.GetName() + " со сладким луком";
        }

        public override int GetCost()
        {
            int result;
            if (InfoManager.ItemsCost.TryGetValue("Сладкий лук", out result))
            {
                return HotDog.GetCost() + result;
            }
            return HotDog.GetCost();
        }

        public override int GetWeight()
        {
            return HotDog.GetWeight() + 10;
        }
    }
}