using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Offensive : SkillsMgr
{
    GameObject player;
    PlayerMgr playerMgr;
    private void Start()
    {
        player = GameObject.Find("Player").gameObject;
        playerMgr = GameObject.Find("Player").GetComponent<PlayerMgr>();

    }

    public void PlayerOffensive()
    {
        if (playerMgr.playerEnergy >= 10)
        {
            Debug.Log("Offen발동");
            playerMgr.playerEnergyMinus(10.0f);
        }
            Destroy(this.gameObject);
    }
}
