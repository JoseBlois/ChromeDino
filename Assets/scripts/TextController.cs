using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject gm;

    // Update is called once per frame
    void Update()
    {
        int score = gm.GetComponent<GameManagerScript>().GetScore();
        gameObject.GetComponent<Text>().text = "SCORE: " + score;
    }
}
