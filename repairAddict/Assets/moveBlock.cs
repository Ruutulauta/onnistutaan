using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBlock : MonoBehaviour
{
    public float moveSpeed;

    scoreManager scoreManager;

    //int playerXDirection = -1;
    //int playerYDirection = -1;

    //Rigidbody2D.velocity = new Vector2(transform.localScale.x * moveSpeed, rigidbody2D.velocity.y);
    

    //private Vector2 startPos;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //scoreManager = GetComponent<scoreManager>();
        //Rigidbody2D.velocity = new Vector2(playerXDirection * transform.localScale.x * moveSpeed, rigidbody2D.velocity.y);
    }

    void Move(){
        //rigidbody2D.velocity = new Vector2(playerXDirection * transform.localScale.x * moveSpeed, rigidbody2D.velocity.y);
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            //playerXDirection = -1;
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("ruuvvi"))
        {
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
