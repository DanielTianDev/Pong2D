using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{


    void Start()
    {
        float randValue = Random.Range(0.0f, 1.0f);
        if (randValue <= 0.5f)
        {     
            GetComponent<Rigidbody2D>().AddForce(new Vector2(100, 10)); //shoot right
        }
        else
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-100, -10)); //left
        }
    }

    void OnCollisionEnter2D(Collision2D collisionDetails)
    {
        if (collisionDetails.collider.tag == "Player")
        {
            Vector2 newPath = GetComponent<Rigidbody2D>().velocity;
            newPath.y = GetComponent<Rigidbody2D>().velocity.y/2 + collisionDetails.collider.attachedRigidbody.velocity.y/3;
            GetComponent<Rigidbody2D>().velocity = newPath;
        }
    }





}
