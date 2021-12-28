using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionGenerator : MonoBehaviour
{
    public Vector3 Generate()
    {
        float spawnX;
        float spawnZ;
        spawnX = Random.Range(-6, 7);
        spawnZ = Random.Range(-6, 7);
        return new Vector3(spawnX, 0, spawnZ);
    }
}
