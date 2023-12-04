using UnityEngine;

namespace TemplateMethod
{
    public class Enemy2 : AEnemy
    {
        public override void Attack(Animator animator)
        {
            animator.SetBool("IsFristAttack", true);
        }
    }
}