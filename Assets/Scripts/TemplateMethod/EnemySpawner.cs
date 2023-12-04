
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
    private int index = 0;
    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        GameObject activeEnemy = Instantiate(Prefabs[index]);
        Enemies[index].TemplateMethod(activeEnemy.GetComponent<Animator>());
        index++;
        yield return new WaitForSeconds(TimeForEnemy);
        Destroy(activeEnemy);

        if (index >= Prefabs.Count - 1)
        {
            yield break;
        }
    }

    private void AddAllEnemies()
    {
        Enemies.Add(new Enemy1());
        Enemies.Add(new Enemy2());
        Enemies.Add(new Enemy3());
    }
}
