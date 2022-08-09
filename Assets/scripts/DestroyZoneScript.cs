using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZoneScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ENEMY DESTROY");
        Destroy(collision.gameObject);
        GameManagerScript script = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        script.IncreaseScore();
        int score = script.GetScore();
    }
}
