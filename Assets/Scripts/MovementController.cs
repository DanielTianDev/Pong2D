using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    public KeyCode moveUp,
        moveDown;

    public float speed = 10.0f;

    public Vector2 initialPos = new Vector2(-13.0f, 0.0f);

    Vector2 move;

    void Start()
    {
        move = new Vector2(0, 0);
    }

    void Update () {

        if (Input.GetKey(moveUp)) //moves up
        {
            if (transform.localPosition.y > PongSetup.TOP_BOUNDS)
            {
                transform.localPosition = new Vector2(transform.localPosition.x, PongSetup.TOP_BOUNDS);
            }
            else
            {
                move.y = speed * Time.deltaTime;
            }
            
        }else if (Input.GetKey(moveDown)) //move down
        {
            if (transform.localPosition.y < PongSetup.BOTTOM_BOUNDS)
            {
                transform.localPosition = new Vector2(transform.localPosition.x, PongSetup.BOTTOM_BOUNDS);
            }
            else
            {
                move.y = -speed * Time.deltaTime;
            }
        }
        else
        {
            move.y = 0;
        }

        transform.Translate(move);
	}
}
