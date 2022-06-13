using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenHeart : MonoBehaviour
{
    public UIManager _uIManager;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Spaceship")
        {
            _uIManager.AddScore(1);
            Destroy(this.gameObject);
        }
    }
}
