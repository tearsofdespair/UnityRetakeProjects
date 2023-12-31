
using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class Client : MonoBehaviour
{
    public Animator Animator;
    private Context _context;
    public delegate void OnDoAttack();
    public event OnDoAttack? DoAttack;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            DoAttack?.Invoke();
        }
    }

    private void Start()
    {
        DoAttack += performAttack;
        _context = new Context(Animator);
    }

    public void ShowFirstAttack()
    {
        _context.SetStrategy(new Attack1());
    }
    
    public void ShowSecondAttack()
    {
        _context.SetStrategy(new Attack2());
    }
    
    public void ShowThirdAttack()
    {
        _context.SetStrategy(new Attack3());
    }

    private void performAttack()
    {
        _context.PerformAttack();
    }
}
