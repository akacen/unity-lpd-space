using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject asteroid;
    public int numberOfCubes;
    public int min, max;

    void Start()
    {
        PlaceCubes();
    }

    void PlaceCubes()
    {
        for (int i = 0; i < numberOfCubes; i++)
        {
            Instantiate(asteroid, GeneratedPosition(), Quaternion.identity);
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
