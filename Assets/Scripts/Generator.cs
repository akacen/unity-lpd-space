using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject asteroid;
    public int min, max, count;
    public GameObject[] asteroids;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    void update()
    {
        
    }

    public IEnumerator SpawnRoutine()
    {
        while (true)
        {
            Instantiate(asteroid, GeneratedPosition(), Quaternion.identity);
            asteroids = GameObject.FindGameObjectsWithTag("Asteroid");
            Debug.Log(asteroids.Length);
            if(asteroids.Length > 50){
                Destroy(asteroids[asteroids.Length - 15]);
            }
            yield return new WaitForSeconds(2);
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
