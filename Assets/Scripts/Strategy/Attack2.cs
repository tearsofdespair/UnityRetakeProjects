using System.Collections;
using UnityEngine;

namespace DefaultNamespace
{
    public class Attack2 : IStrategy
    {
        public void PerformAttack(Animator animator)
        {
            animator.Play("SecondAttackAnimation");
        }
    }
}