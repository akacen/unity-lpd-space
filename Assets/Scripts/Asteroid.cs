using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Asteroid : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Spaceship")
        {
            Destroy(other.gameObject);
            GameObject.FindGameObjectWithTag("GameOver").GetComponent<Text>().enabled = true;
            GameObject mainCamera = GameObject.FindWithTag("MainCamera");
            mainCamera.GetComponent<Generator>().enabled = false;
        }
    }
}
