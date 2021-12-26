using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab; 

    private void Update()
    {
        Instantiate(enemyPrefab);
    }
}
