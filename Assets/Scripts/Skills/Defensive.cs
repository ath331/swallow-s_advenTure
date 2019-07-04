using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defensive : MonoBehaviour
{
    GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player").gameObject;
    }

    public void PlayerDefensive()
    {
        Debug.Log("Defen발동");
        Destroy(this.gameObject);
    }
}
