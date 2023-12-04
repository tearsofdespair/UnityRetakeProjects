using UnityEngine;

namespace TemplateMethod
{
    public abstract class AEnemy
    {
        
        public abstract void Attack(Animator animator);


        public void TemplateMethod(Animator animator)
        {
            Attack(animator);
        }
    }
}