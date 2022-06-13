using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;

   [SerializeField]
    private int _score;

    // Start is called before the first frame update
    void Start()
    {
        _scoreText.text = "Score: " + 0;
    }

    public void AddScore(int _point)
    {
        _score += _point;
        _scoreText.text = "Score: " + _score.ToString();
    }
}
