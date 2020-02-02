using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movingGranny : MonoBehaviour {

    public Transform pointA;
    public Transform pointB;
    
    float maxSpeed = 1;

    bool moveToTarget = false;

    void Update () {

        float distanceToTarget = Vector3.Distance(pointB.position, transform.position);
        float distanceToStart = Vector3.Distance(pointA.position, transform.position);


        float speed = Mathf.Min(distanceToStart, distanceToTarget, maxSpeed) + 0.5f;


        if (transform.position == pointB.position)
        {
            moveToTarget = false;
        }
        else if (transform.position == pointA.position)
        {
            moveToTarget = true;
        }

        if (moveToTarget == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointA.position, speed * Time.deltaTime);
        }
        else if (moveToTarget == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointB.position, speed * Time.deltaTime);
        }
	}

    void OnTriggerEnter2D(Collider2D other)
        {
            if(other.gameObject.CompareTag("Player"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
}
