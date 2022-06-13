using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartGenerator : MonoBehaviour
{
    public GameObject heart;
    public int numberOfHearts;
    public int min, max;

    void Start()
    {
        PlaceCubes();
    }

    void PlaceCubes()
    {
        for (int i = 0; i < numberOfHearts; i++)
        {
            Instantiate(heart, GeneratedPosition(), Quaternion.identity);
        }
    }

    Vector3 GeneratedPosition()
    {
        int x, y, z;
        x = UnityEngine.Random.Range(min, max);
        y = UnityEngine.Random.Range(min, max);
        z = UnityEngine.Random.Range(min, max);
        return new Vector3(x, y, z);
    }
}
