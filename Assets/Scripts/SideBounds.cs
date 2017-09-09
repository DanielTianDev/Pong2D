using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideBounds : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {

        if (hitInfo.name.Contains("Ball"))
        {
            String sideName = transform.name;
            GameController.Score(sideName);
            hitInfo.gameObject.SendMessage("SesetBallPosition");
        }
    }
}
