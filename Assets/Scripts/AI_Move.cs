using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Move : MonoBehaviour {

    public float AIMoveSpeed = 6.5f;

    private GameObject ball;
	
	void Update () {

        ball = GameObject.FindWithTag("Ball");

        if(ball != null)
        {
            MoveTowardsY(ball.transform.position);
        }
        
	}

    void MoveTowardsY(Vector3 destination)
    {
        float distanceToBall = Mathf.Abs(ball.transform.position.x - transform.position.x);
        Vector2 MovePos;

        if (distanceToBall < 2.0f)
        {
            MovePos = new Vector2(transform.position.x, transform.position.y + 15 * Time.deltaTime);
        }
        else
        {
            float Direction = Mathf.Sign(destination.y - transform.position.y);
            MovePos = new Vector2(
                transform.position.x, //MoveTowards on 1 axis
                transform.position.y + Direction * AIMoveSpeed * Time.deltaTime
            );
        }

        transform.position = MovePos;
    }
}
