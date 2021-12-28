using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private EnemyMover _enemyPrefab;

    [SerializeField] private int _currentEnemiesCount;
    [SerializeField] private int _waveNumber = 1;
    private Vector3 _spawnOffset;

    public UnityEvent OnLastEnemyDestroyed;

    private void Update()
    {
        _currentEnemiesCount = FindObjectsOfType<EnemyMover>().Length;

        if (_currentEnemiesCount == 0)
        {
            SpawnEnemies(_waveNumber);
            _waveNumber++;
        }
    }

    public void SpawnEnemies(int enemiesCount)
    {
        for (int i = 0; i < enemiesCount; i++)
        {
            _spawnOffset = new Vector3(Random.Range(0, 5), 0, Random.Range(0, 5));
            EnemyMover enemy = Instantiate(_enemyPrefab, transform.position + _spawnOffset, transform.rotation);
            enemy.SetPlayerTransform(_playerTransform);
        }
    }
}
