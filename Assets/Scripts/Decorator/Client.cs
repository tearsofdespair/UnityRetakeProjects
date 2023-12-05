using System;
using System.Collections.Generic;
using UnityEngine;

namespace Decorator
{
    public class Client : MonoBehaviour
    {
        public HotDogObject HotDogObject;
        private List<HotDog> _hotDogs = new List<HotDog>()
            { new ClassicHotdog(), new CezaurHotdog(), new MeatHotDog() };
        private void Start()
        {
            ShowFullInfo();
            ShowHotDogFromScriptableObject();
        }


        public void ShowHotDogFromScriptableObject()
        {
            HotDog result;
            HotDogDecorator decorator;
            if (InfoManager.EnumTypeToHotdog.TryGetValue(HotDogObject.Type, out result))
            {
                switch (HotDogObject.Decorator)
                {
                    case HotDogDecoratorTypes.Cucumber:
                        decorator = new HotDogCucumberDecorator(result);
                        ShowHotDogInfo(decorator);
                        break;
                    case HotDogDecoratorTypes.Onion:
                        decorator = new HotDogOnionDecorator(result);
                        ShowHotDogInfo(decorator);
                        break;
                    case HotDogDecoratorTypes.Nothing:
                        ShowHotDogInfo(result);
                        break;
                }
            }
        }

        public void ShowHotDogInfo(HotDogDecorator decorator)
        {
            Debug.Log(decorator.GetName() + " - (" + decorator.GetWeight() + ") - " + decorator.GetCost());
        }
        
        public void ShowHotDogInfo(HotDog hotDog)
        {
            Debug.Log(hotDog.GetName() + " - (" + hotDog.GetWeight() + ") - " + hotDog.GetCost());
        }
        
        public void ShowFullInfo()
        {
            HotDog hotDog;
            HotDogDecorator hotDogcucumberDecorator;
            HotDogDecorator hotDogonionDecorator;

            foreach (HotDog dog in _hotDogs)
            {
                hotDog = dog;
                
                hotDogcucumberDecorator = new HotDogCucumberDecorator(hotDog);
                hotDogonionDecorator = new HotDogOnionDecorator(hotDog);
                
                Debug.Log(hotDog.GetName() + " - (" + hotDog.GetWeight() + ") - "+ hotDog.GetCost());
                Debug.Log("Дополнительная информация: ");
                Debug.Log(hotDogcucumberDecorator.GetName() + " - (" + hotDogcucumberDecorator.GetWeight() + ") - " + hotDogcucumberDecorator.GetCost());
                Debug.Log(hotDogonionDecorator.GetName() + " - (" + hotDogonionDecorator.GetWeight() + ") - " + hotDogonionDecorator.GetCost());
            }
        }
    }
}