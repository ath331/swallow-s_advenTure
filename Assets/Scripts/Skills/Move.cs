using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    GameObject player;
    PlayerMgr playerMgr;

    SkillsMgr skillMgr;
    private Text moveText;
    int num;

    private void Start()
    {
        player = GameObject.Find("Player").gameObject;
        playerMgr = GameObject.Find("Player").GetComponent<PlayerMgr>();
        skillMgr = this.gameObject.GetComponent<SkillsMgr>();
        moveText = skillMgr.moveText;
        num = Random.Range(0, 4);

        Debug.Log("Move num : " + num);
        if (num == 0)
        {
            moveText.text = "UP";
            Debug.Log("UP할당");
        }
        else if (num == 1)
        {
            moveText.text = "DOWN";
            Debug.Log("DOWN할당");
        }
        else if (num == 2)
        {
            moveText.text = "LEFT";
            Debug.Log("LEFT할당");
        }
        else if (num == 3)
        {
            moveText.text = "RIGHT";
            Debug.Log("RIGHT할당");
        }

    }

    public void PlayerMove()
    {
        if (playerMgr.playerEnergy >= 10)
        {
            Debug.Log("Move발동");
            if (num == 0)//Up
            {
                if (player.transform.position.y + 2.2f <= 3.0f)
                {
                    player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y + 2.2f);
                    playerMgr.playerEnergyMinus(10.0f);
                }
            }
            else if (num == 1)//Down
            {
                if (player.transform.position.y - 2.2f >= -3.0f)
                {
                    player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y - 2.2f);
                    playerMgr.playerEnergyMinus(10.0f);
                }
            }
            else if (num == 3)// >
            {
                if (player.transform.position.x + 4.0f <= 7.0f)
                {
                    player.transform.position = new Vector2(player.transform.position.x + 4.0f, player.transform.position.y);
                    playerMgr.playerEnergyMinus(10.0f);
                }
            }
            else if (num == 2)// <
            {
                if (player.transform.position.x - 4.0f >= -10.0f)
                {
                    player.transform.position = new Vector2(player.transform.position.x - 4.0f, player.transform.position.y);
                    playerMgr.playerEnergyMinus(10.0f);
                }
            }
            //애니메이션 추가
        }
        Destroy(this.gameObject);
    }
}
