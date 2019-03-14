using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManagement : MonoBehaviour
{
    private Button Logo, Main_JoinGame, Join_JoinGame;
    public GameObject GameManager;

    public Player local;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void Home()
    {
        SceneManager.LoadScene("Main");
    }

    public void JoinGameScene()
    {
        SceneManager.LoadScene("Join Game");
    }

    public void JoinGame()
    {
        local = new Player("");
        local.SetLocal();
        SceneManager.LoadScene("Lobby");
    }
}
