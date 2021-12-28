using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    [SerializeField] private Powerup _prefab;
    [SerializeField] private EnemySpawner _enemySpawner;
    private Vector3 _spawnPosOffset;
    [SerializeField] private PositionGenerator _positionGenerator;
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
            _spawnPosOffset = _positionGenerator.Generate();
            Instantiate(_prefab, transform.position + _spawnPosOffset, transform.rotation);
        }
    }
}