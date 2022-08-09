using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore() {
        score += 1;
        Debug.Log("Score: " + score);
    }

    public int GetScore() {
        return score;
    }
}
