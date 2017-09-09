using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    public float ballSpeed = 100f;

    void Start()
    {
        StartCoroutine(SpawnBall());
    }

    IEnumerator SpawnBall()
    {
        yield return new WaitForSeconds(1f);

        float randValue = Random.Range(0.0f, 1.0f);
        if (randValue <= 0.5f)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(ballSpeed, 10)); //shoot right
        }
        else
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-ballSpeed, -10)); //left
        }
    }

    public IEnumerator SesetBallPosition()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2();
        transform.position = new Vector3(0 , 0);

        yield return new WaitForSeconds(0.5f);
        StartCoroutine(SpawnBall());
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
