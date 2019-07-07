using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defensive : MonoBehaviour
{
    GameObject player;
    PlayerMgr playerMgr;
    private void Start()
    {
        player = GameObject.Find("Player").gameObject;
        playerMgr = GameObject.Find("Player").GetComponent<PlayerMgr>();
    }

    public void PlayerDefensive()
    {
        if (playerMgr.playerEnergy <= 100.0f)
        {
            Debug.Log("Defen발동");
            playerMgr.playerEnergyMinus(-10.0f); //에너지 충전
            if (playerMgr.playerEnergy > 100)
                playerMgr.playerEnergy = 100;
        }
            Destroy(this.gameObject);
    }
}
