using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Offensive : SkillsMgr
{
    GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player").gameObject;
    }

    public void PlayerOffensive()
    {
        Debug.Log("Offen발동");
        Destroy(this.gameObject);
    }
}
