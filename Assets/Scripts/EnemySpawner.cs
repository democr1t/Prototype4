using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private EnemyMover _enemyPrefab;

    [SerializeField] private float _startDelay = 3;
    [SerializeField] private float _spawnInterval = 10;

    private Vector3 _spawnPos;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnEnemies), _startDelay, _spawnInterval);
    }

    private void SpawnEnemies()
    {
        EnemyMover enemy = Instantiate(_enemyPrefab, transform);
        enemy.SetPlayerTransform(_playerTransform);
    }
}
