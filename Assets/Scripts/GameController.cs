using UnityEngine;
using System.Collections;
using System;

//controls the game

public class GameController : MonoBehaviour
{

    public static int playerScore1 = 0,
        playerScore2 = 0;

    public GUISkin skin;

    private GameObject ball;

    void Start()
    {
        InstantiateBall();
    }

    private void OnGUI()
    {
        GUI.skin = this.skin;
        GUI.Label(new Rect(Screen.width/2 - 150 - 12,  20, 100, 100), "P1: " + playerScore1);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "P1: " + playerScore2);
    }


    void InstantiateBall() { 
            ball = GameObject.Instantiate((GameObject)Resources.Load("Prefabs/ball", typeof(GameObject)));
            ball.transform.localPosition = new Vector3(0f, 0f, 0f);
    }

    public static void Score(String wallName)
    {
        if (wallName == "rightCollider")
        {
            playerScore1++;
        }
        else
        {
            playerScore2++;
        }

    }
}
