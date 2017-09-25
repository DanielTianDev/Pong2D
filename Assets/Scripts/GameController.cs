using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

//controls the game

public class GameController : MonoBehaviour
{
    public static int playerScore1 = 0,
        playerScore2 = 0;
    public int winScore = 3;

    private bool isGameActive = false;

    public GUISkin skin;
    public GameObject ball, player1, player2;

    private GameObject currentBall;

    //UI control
    public Button btnHuman, btnComputer, btnQuit;
    public Text statusText;

    void Start()
    {
        SetLobbyUI(true); //is in lobby
    }

    //if  true, returns to lobby. if not then the game ui will be displayed.
    void SetLobbyUI(bool isVisible)
    {
        btnHuman.gameObject.SetActive(isVisible);
        btnComputer.gameObject.SetActive(isVisible);
        btnQuit.gameObject.SetActive(!isVisible);
    }

    public void QuitGame()
    {
        Destroy(currentBall);
        SetLobbyUI(true); //back to lobby
        playerScore1 = 0;
        playerScore2 = 0;
        player1.SetActive(false);
        player2.SetActive(false);
        isGameActive = false;
    }

    public void StartGame()
    {
        SetLobbyUI(false);
        isGameActive = true;
        player1.SetActive(true);
        player2.SetActive(true);
    }

    public void StartPlayerVsPlayer()
    {
        StartGame();
        InstantiateBall();
    }

    public void StartPlayerVsAI()
    {
        StartGame();
        InstantiateBall();
    }



    private void OnGUI()
    {
        if (isGameActive)
        {
            GUI.skin = this.skin;
            GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "P1: " + playerScore1);
            GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "P1: " + playerScore2);
        }
    }


    void InstantiateBall() {
        //ball = GameObject.Instantiate((GameObject)Resources.Load("Prefabs/ball", typeof(GameObject)));
        currentBall = Instantiate(ball);
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
    private void Update()
    {
        isGameWon();
        print("p1: " + playerScore1 + " p2: " + playerScore2);
    }

    public void isGameWon()
    {
        if (playerScore1 >= winScore)
        {
            StartCoroutine(GameWon(1));
        }
        else if (playerScore2 >= winScore)
        {
            StartCoroutine(GameWon(2));
        }
    }

    IEnumerator GameWon(int playerNum)
    {
        statusText.text = "Player " + playerNum + " has won!";
        yield return new WaitForSeconds(3.0f);
        statusText.text = "";
        QuitGame();
    }

}
