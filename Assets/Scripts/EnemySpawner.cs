using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private EnemyMover _enemyPrefab;
    [SerializeField] public int CurrentCount { get; private set; }
    [SerializeField] public int WaveNumber { get; private set; }
    private Vector3 _spawnOffset;

    private void Start()
    {
        WaveNumber = 1;
    }

    private void Update()
    {
        CurrentCount = FindObjectsOfType<EnemyMover>().Length;

        if (CurrentCount == 0)
        {
            Spawn(WaveNumber);
            WaveNumber++;
        }
    }

    public void Spawn(int enemiesCount)
    {
        for (int i = 0; i < enemiesCount; i++)
        {
            _spawnOffset = new Vector3(Random.Range(0, 5), 0, Random.Range(0, 5));
            EnemyMover enemy = Instantiate(_enemyPrefab, transform.position + _spawnOffset, transform.rotation);
            enemy.SetPlayerTransform(_playerTransform);
        }
    }
}
