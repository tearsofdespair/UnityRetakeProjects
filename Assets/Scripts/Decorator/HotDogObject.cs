using System.Collections;
using System.Collections.Generic;
using Decorator;
using UnityEngine;
[CreateAssetMenu(fileName = "New HotDog", menuName = "Hotdogs/Hotdog")]
public class HotDogObject : ScriptableObject
{
    public HotdogTypes Type;
    public HotDogDecoratorTypes Decorator;
}
