using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    [SerializeField] private Powerup _prefab;
    [SerializeField] private EnemySpawner _enemySpawner;
    private Vector3 _spawnPos;
    private float _spawnX;
    private float _spawnZ;
    private int _count;

    private void Update()
    {
        if(_enemySpawner.CurrentCount == 0)
        {
            Spawn(_count);
            ++_count;
        }
    }
    private void Spawn(int count)
    {
        for (int i = 0; i < count; i++)
        {
            _spawnX = Random.Range(-6, 7);
            _spawnZ = Random.Range(-6, 7);
            _spawnPos = new Vector3(_spawnX, 0, _spawnZ);
            Instantiate(_prefab, transform.position + _spawnPos, transform.rotation);
        }
    }
  
}
