
using System;
using System.Collections;
using System.Collections.Generic;
using TemplateMethod;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float TimeForEnemy;
    private List<AEnemy> Enemies = new List<AEnemy>();
    private int index = 0;
    private void Start()
    {
        
    }

    IEnumerator SpawnEnemies()
    {
        GameObject activeEnemy = Enemies[0].TemplateMethod(5, 2, );
    }
}
