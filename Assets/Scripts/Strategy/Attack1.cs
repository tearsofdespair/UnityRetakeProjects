using System.Collections;

using UnityEngine;

namespace DefaultNamespace
{
    public class Attack1 : IStrategy
    {
        public void PerformAttack(Animator animator)
        {
            animator.Play("FirstAttackAnimation");
        }

        
    }
}