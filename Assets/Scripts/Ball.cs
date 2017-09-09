using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{

    public float ballSpeed = 15.0f;

    public Vector2 ballDirection = Vector2.left;




    void Start()
    {

    }

    void Update()
    {
        MoveBall();
    }

    private void MoveBall()
    {
        transform.Translate(ballDirection * ballSpeed * Time.deltaTime);
    }



}
