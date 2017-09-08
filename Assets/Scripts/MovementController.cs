using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    public KeyCode moveUp,
        moveDown;

    public float speed = 10.0f;

    private Rigidbody2D playerRigidbody2D;

    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKey(moveUp)) //moves up
        {
            this.transform.Translate(0, speed * Time.deltaTime, 0);
        }else if (Input.GetKey(moveDown)) //move down
        {
            //playerRigidbody2D.velocity.Set(speed, -speed);
            this.transform.Translate(0, -speed * Time.deltaTime, 0);
        }
        else
        {
            this.transform.Translate(0, 0, 0);
        }

	}
}
