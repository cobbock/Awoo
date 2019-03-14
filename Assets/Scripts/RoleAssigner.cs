using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Photon.Pun;

public class RoleAssigner : MonoBehaviour
{
    List<string> roles = new List<string>();
    string role = "";

    // Start is called before the first frame update
    void Start()
    {
        roles.Add("villager");
        roles.Add("werewolf");
        roles.Add("seer");
        roles.Add("spellweaver");
        int i;
        for (i = 0; i < PhotonNetwork.CountOfPlayers;)
        {
            int r = Random.Range(0, 3);
            role = roles[r];
            roles.Remove(roles[r]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
