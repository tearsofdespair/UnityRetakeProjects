using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class Context
{
    private IStrategy _strategy;
    private Animator _animator;
    public Context(Animator animator)
    {
        _animator = animator;
    }
    
    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void PerformAttack()
    {
        _strategy.PerformAttack(_animator);
    }
}
