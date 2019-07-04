using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player").gameObject;
    }

    public void PlayerMove()
    {
        Debug.Log("Move발동");
        player.transform.position = new Vector2(player.transform.position.x + 4 , 0);
        Destroy(this.gameObject);
        
    }
}
