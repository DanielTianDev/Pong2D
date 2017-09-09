using UnityEngine;
using System.Collections;
using System;

//controls the game

public class GameController : MonoBehaviour
{

    private GameObject ball;

    void Start()
    {
        SpawnBall();
    }
    void Update()
    {

    }

    void SpawnBall() { 
    
        try{
            ball = GameObject.Instantiate((GameObject)Resources.Load("Prefabs/ball", typeof(GameObject)));
            ball.transform.localPosition = new Vector3(0, -2.5f, 0);
        }
        catch(Exception e){
            print("exception: " + e.Message.ToString());
        }
      
    }
}
