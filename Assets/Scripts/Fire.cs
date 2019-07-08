using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    GameObject fire;

    PlayerMgr playerMgr;
    EnermyMgr enermyMgr;

    private void Start()
    {
        fire = GameObject.Find("Player").GetComponent<PlayerMgr>().firePos;
        playerMgr = GameObject.Find("Player").GetComponent<PlayerMgr>();
        enermyMgr = GameObject.Find("Enermy").GetComponent<EnermyMgr>();
    }

    public void FireShot()
    {
        Instantiate(playerMgr.bull, new Vector3(fire.transform.position.x, fire.transform.position.y, fire.transform.position.z), fire.transform.rotation);
    }

    public void OnTriggerEnter(Collider col)
    {
        if(col.tag.Equals("Player"))
        {
            playerMgr.playerHPMinus(10.0f);
            Destroy(this.gameObject);
        }
        else if(col.tag.Equals("Enermy"))
        {
            enermyMgr.EnermyHPMinus(10);
            Destroy(this.gameObject);
        }

    }
}
