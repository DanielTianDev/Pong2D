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
            
        }else if (Input.GetKey(moveDown)) //move down
        {
            move.y = speed * -1f;
        }
        else
        {
            move.y = 0;
        }
        
        /*
        float translation = Input.GetAxis("Vertical") * speed;

        if(translation > 0)
        {
            move.y = speed;
        }else if(translation < 0)
        {
            move.y = -speed;
        }
        else
        {
            move.y = 0;
        }
        */

        GetComponent<Rigidbody2D>().velocity = move;
    }
}
