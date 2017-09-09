using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    public KeyCode moveUp,
        moveDown;

    public float speed = 20.0f;

    public Vector2 initialPos = new Vector2(-13.0f, 0.0f);

    Vector2 move;

    void Start()
    {
        move = new Vector2(0, speed);
    }

    void Update () {

        if (Input.GetKey(moveUp)) //moves up
        {
            move.y = speed;
            /*
            if (transform.localPosition.y >= PongSetup.getTopBounds())
            {
                transform.localPosition = new Vector2(transform.localPosition.x, PongSetup.getTopBounds());
            }
            else
            {
                move.y = speed * Time.deltaTime;            
            }*/
        }else if (Input.GetKey(moveDown)) //move down
        {
            move.y = speed * -1f;
            /*
            if (transform.localPosition.y <= PongSetup.getBottomBounds())
            {
                transform.localPosition = new Vector2(transform.localPosition.x, PongSetup.getBottomBounds());
            }
            else
            {
                move.y = -speed * Time.deltaTime;
            }*/
        }
        else
        {
            move.y = 0;
        }

        GetComponent<Rigidbody2D>().velocity = move;
        //transform.Translate(move);
    }
}
