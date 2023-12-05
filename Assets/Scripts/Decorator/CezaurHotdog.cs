namespace Decorator
{
    public class CezaurHotdog: HotDog
    {
        
        
        public override string GetName()
        {
            return "Хот-Дог Цезарь";
        }

        public override int GetCost()
        {
            return 290;
        }

        public override int GetWeight()
        {
            return 200;
        }
    }
}