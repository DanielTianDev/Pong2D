using UnityEngine;
using UnityEngine.UI;

public class Console : MonoBehaviour
{

    public InputField inputField;

    public GameObject player1, player2, backgroundImage;

    void Start()
    {
        inputField.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            inputField.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            inputField.gameObject.SetActive(false);
        }
    }

    public void ProcessCommand()
    {
        if(inputField.text == "Player1.Enlarge")
        {
            //Lengthens player1 by 0.1
            player1.transform.localScale += new Vector3(0, 0.1f, 0);
        }
        else if(inputField.text == "Player1.Shrink")
        {
            //Shrinks player1 by 0.1
            player1.transform.localScale -= new Vector3(0, 0.1f, 0);
        }
        else if (inputField.text == "Player2.Enlarge")
        {
            //Lengthens player2 by 0.1
            player2.transform.localScale += new Vector3(0, 0.1f, 0);
        }
        else if (inputField.text == "Player2.Shrink")
        {
            //Shrinks player2 by 0.1
            player2.transform.localScale -= new Vector3(0, 0.1f, 0);
        }else if (inputField.text == "Background.ChangeColor")
        {
            backgroundImage.gameObject.SetActive(!backgroundImage.gameObject.activeSelf);
        }
    }
}
