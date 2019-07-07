using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    GameObject player;
    PlayerMgr playerMgr;
    SkillHandler skillHandler;

    private Text moveText;

    private void Start()
    {
        player = GameObject.Find("Player").gameObject;
        playerMgr = GameObject.Find("Player").GetComponent<PlayerMgr>();
       /* skillHandler = this.gameObject.GetComponent<SkillHandler>();

        int num = Random.Range(0, 4);
        if (num == 0)
        {
            skillHandler.moveText.text = "UP";
            Debug.Log("UP할당");
        }*/


    }

    public void PlayerMove()
    {
        if (playerMgr.playerEnergy >= 10)
        {

            Debug.Log("Move발동");
            if (player.transform.position.x + 4.0f <= 7)
            {
                player.transform.position = new Vector2(player.transform.position.x + 4.0f, 0.0f);
                playerMgr.playerEnergyMinus(10.0f);
            }
            //애니메이션 추가
        }
        Destroy(this.gameObject);
    }
}
