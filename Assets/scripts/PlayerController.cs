using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private bool isGrounded;
    private float jumpBufferTime = 0.2f;
    private float jumpBufferCounter;

    void Start() {
        jumpBufferCounter = jumpBufferTime;
    }

    // Update is called once per frame
    void Update()
    {
        // RigidBody2D = GetComponent<Rigidbody2D>();
        if (Input.GetKeyDown(KeyCode.Space)) {
            jumpBufferCounter = jumpBufferTime;

        } else {
            jumpBufferCounter -= Time.deltaTime;
        }

        if (isGrounded && jumpBufferCounter > 0)
            {   
                gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * 10;
                isGrounded = false;
            }
            else {
            }

        if (gameObject.GetComponent<Rigidbody2D>().velocity.y < 0) {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 5.5f;
        } else {
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 2f;
        }
    }

    private void  OnCollisionEnter2D(Collision2D collision) {
        if (collision.transform.tag == "GROUND") {
            isGrounded = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "ENEMY" || collision.transform.tag == "ENEMY_RED")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
