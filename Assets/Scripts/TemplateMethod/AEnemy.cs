using UnityEngine;

namespace TemplateMethod
{
    public abstract class AEnemy
    {
        public abstract void Spawn(float x, float y, GameObject gameObject, out GameObject instantObject);
        public abstract void Attack(Animator animator);


        public GameObject TemplateMethod(float x, float y, Animator animator, GameObject gameObject)
        {
            GameObject instantObject;
            Spawn(x, y, gameObject, out instantObject);
            Attack(instantObject.GetComponent<Animator>());

            return instantObject;
        }
    }
}