using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Diagnostics;
using System.Threading;
using Photon.Pun;

public class GameManagement : MonoBehaviour
{

    private Text Status, Instructions;
    private GameObject TargetInputHolder, UIManager;
    private ScrollRect GameList;
    private InputField TargetInput, PlayerName;
    private Text PlayersText, NoPlayers;

    public string target;
    
    private Scene currentScene = SceneManager.GetActiveScene();

    // Start is called before the first frame update
    void Start()
    {
        if (currentScene.name == "Lobby")
        {
            LobbyScene();
        }
        if (currentScene.name == "Night")
        {
            NightScene();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (currentScene.name == "Lobby")
        {
            PlayersText.text = PhotonNetwork.PlayerList.ToString();
            NoPlayers.text = PhotonNetwork.CountOfPlayers.ToString();
        }
    }

    void LobbyScene()
    {

    }

    void NightScene()
    {
        UiManagement ui = UIManager.GetComponent<UiManagement>();
        Player local = ui.local;
        TargetInputHolder.SetActive(false);
        Handheld.Vibrate();
        Status.text = "Sleeping...";
        Thread.Sleep(5000);
        if (local.role == "werewolf")
        {
            Handheld.Vibrate();
            Status.text = "Wake Up.";
            Thread.Sleep(2000);
            Instructions.text = "Choose Your Target";
            TargetInputHolder.SetActive(true);
            Thread.Sleep(20000);
            target = TargetInput.text;
            TargetInputHolder.SetActive(false);
            Instructions.text = "Target chosen. It's time to sleep again.";
        }

        if (local.role == "seer")
        {

        }
    }
}