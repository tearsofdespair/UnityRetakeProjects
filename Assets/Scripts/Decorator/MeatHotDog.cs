namespace Decorator
{
    public class MeatHotDog : HotDog
    {
        public override string GetName()
        {
            return "Хот-Дог Мясной";
        }

        public override int GetCost()
        {
            return 330;
        }

        public override int GetWeight()
        {
            return 240;
        }
    }
}