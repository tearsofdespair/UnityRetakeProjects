using UnityEngine;

namespace TemplateMethod
{
    public class Enemy1 : AEnemy
    {
        

        public override void Attack(Animator animator)
        {
            animator.Play("FirstAttackAnimation");
        }
    }
}