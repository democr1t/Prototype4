using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupIndicator : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void Update()
    {
          transform.position = _player.transform.position;
    }
}
