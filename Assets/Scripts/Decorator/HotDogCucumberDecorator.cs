namespace Decorator
{
    public class HotDogCucumberDecorator : HotDogDecorator
    {
        public HotDogCucumberDecorator(HotDog hotDog) : base(hotDog)
        {
        }

        public override string GetName()
        {
            return HotDog.GetName() + " с маринованными огурцами";
        }

        public override int GetCost()
        {
            int result;
            if (InfoManager.ItemsCost.TryGetValue("Маринованые огурцы", out result))
            {
                return HotDog.GetCost() + result;
            }
            return HotDog.GetCost();
        }

        public override int GetWeight()
        {
            return HotDog.GetWeight() + 20;
        }
    }
}