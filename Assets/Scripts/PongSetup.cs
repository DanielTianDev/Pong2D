using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongSetup : MonoBehaviour {

    public static float TOP_BOUNDS = 3.7f,
        BOTTOM_BOUNDS = -9.3f;

    public Camera mainCamera;

    BoxCollider2D northBoundary, eastBoundary, southBoundary, westBoundary;

    Transform player1, player2;


	void Start () {
		
	}

	void Update () {
        //move each boundary to the edge location of the screen
        northBoundary.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
	}
}
