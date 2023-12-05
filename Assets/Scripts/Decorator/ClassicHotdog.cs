namespace Decorator
{
    public class ClassicHotdog : HotDog
    {

        public override string GetName()
        {
            return "Хот-Дог Классический";
        }

        public override int GetCost()
        {
            return 210;
        }

        public override int GetWeight()
        {
            return 150;
        }
    }
}