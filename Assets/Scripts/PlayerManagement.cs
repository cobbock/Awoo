using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManagement : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Player : MonoBehaviour
{
    public static Player instance = null;

    private InputField PlayerName;
    public string uname;
    public string role;

    public Player(string uname)
    {
        this.uname = uname;
    }

    public void SetLocal()
    {
        var localName = PlayerName.text;
        this.uname = localName;
    }
}