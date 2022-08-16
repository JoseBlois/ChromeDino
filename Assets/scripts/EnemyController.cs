using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {

        //gameObject.transform.Translate(Vector2.left * 25f * Time.deltaTime);

        //THIS CODE ASSIGN DIFFERENT SPEED TO OBJECTS WITH TAG = "ENEMY_RED";
        if (gameObject.transform.tag == "ENEMY_RED")
        {
            gameObject.transform.Translate(Vector2.left * 35f * Time.deltaTime);
        }
        else
        {
            gameObject.transform.Translate(Vector2.left * 25f * Time.deltaTime);
        }
    }

}
