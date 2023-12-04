
using System;
using System.Collections;
using System.Collections.Generic;
using TemplateMethod;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float TimeForEnemy;
    public List<GameObject> Prefabs = new List<GameObject>();
    private List<AEnemy> Enemies = new List<AEnemy>();
    private void Start()
    {
        AddAllEnemies();
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        for (int i = 0; i < Enemies.Count; i++)
        {
            GameObject activeEnemy = Instantiate(Prefabs[i]);
            Enemies[i].TemplateMethod(activeEnemy.GetComponent<Animator>());
            Debug.Log("Spawn");
        
            yield return new WaitForSeconds(TimeForEnemy);
            Destroy(activeEnemy);
        }

        
    }

    private void AddAllEnemies()
    {
        Enemies.Add(new Enemy1());
        Enemies.Add(new Enemy2());
    }
}
