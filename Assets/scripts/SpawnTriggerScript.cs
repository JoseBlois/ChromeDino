using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTriggerScript : MonoBehaviour
{
    [SerializeField] GameObject sm;
    [SerializeField] GameObject gm;
    private int score;
    private int oldScore;
    private float position;


    public void Start()
    {
       position = gameObject.transform.position.x;
    }
    public void Update()
    {
/*        GameManagerScript script = GameObject.Find("GameManager")
            .GetComponent<GameManagerScript>();

        score = script.GetScore();
        if (score != 0  && score <= 28 && score != oldScore) {
            Debug.Log("score from spawn trigger: " + score);
        oldScore = score;
        float newX = position + (score * 0.04f);
        gameObject.transform.position =  new Vector3(newX, gameObject.transform.position.y, gameObject.transform.position.z);
        position = gameObject.transform.position.x;
        }*/
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "ENEMY" || collision.transform.tag == "ENEMY_RED")
        {
            sm.GetComponent<SpawnerManagerScript>()
                .SpawnEnemy();
        }
    }*/

}
