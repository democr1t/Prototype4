using UnityEngine;

public class Powerup : MonoBehaviour
{
    static public float Power {  get; private set; }

    private void Start()
    {
        Power = 1000;
    }
}
