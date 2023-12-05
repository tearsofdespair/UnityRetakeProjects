using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Decorator
{
    public static class InfoManager
    {
        public static Dictionary<string, int> ItemsCost = new Dictionary<string, int>() {{"Маринованые огурцы", 50}, {"Сладкий лук", 30}};
        public static Dictionary<HotdogTypes, HotDog> EnumTypeToHotdog = new Dictionary<HotdogTypes, HotDog>() 
        { { HotdogTypes.Classic, new ClassicHotdog()}, { HotdogTypes.Cezuar, new CezaurHotdog()}, { HotdogTypes.Meat, new MeatHotDog()} };
    }
}