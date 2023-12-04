using System.Collections;
using UnityEngine;

namespace DefaultNamespace
{
    public class Attack3 : IStrategy
    {
        public void PerformAttack(Animator animator)
        {
            animator.Play("ThirdAttack");
        }
        
    }
}