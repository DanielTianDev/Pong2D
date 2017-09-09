using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongSetup : MonoBehaviour {

    public Camera mainCamera;

    public BoxCollider2D northBoundary, eastBoundary, southBoundary, westBoundary;

    public Transform player1, player2;

    public static float topBound, bottomBound;

	void Start () {

        topBound = mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y - 4f;
        bottomBound = (mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y  *  -1f) + 4f;
        print(bottomBound);

        //move each boundary to the edge location of the screen
        northBoundary.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        northBoundary.offset = new Vector2(0f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y);

        southBoundary.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        southBoundary.offset = new Vector2(0f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y * -1f);

        westBoundary.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y); //left
        westBoundary.offset = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x, 0f);

        eastBoundary.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y); //right wall
        eastBoundary.offset = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x, 0f);

        //set up player positions
        player1.localPosition = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(125f, 0f, 0f)).x, player1.localPosition.y);
        player2.localPosition = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width - 125f, 0f, 0f)).x, player2.localPosition.y); 
    }

    public static float getTopBounds()
    {
        return topBound;
    }

    public static float getBottomBounds()
    {
        return bottomBound;
    }
}
