using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    public static GameMgr instance = null;
    public GameObject player;
    public GameObject skillPanel;
    public int skillCounts = 0;

    public Transform[] floors;//Stage의 Floor들을 배열로 받기위한 변수

    private bool playerTurn = true; //플레이어의 턴을 구별하기위한 변수

    private void Awake()
    {
        instance = this;
        Debug.Log("게임매니저 스크립트을 싱글턴화");
    }

    void Start()
    {
        floors = GameObject.Find("Stage").GetComponentsInChildren<Transform>();
        player.transform.position = floors[5].transform.position; //Player위치를 배열5번칸 (2행1열)로 배치
        Debug.Log("Plater위치 할당");
    }
    private void Update()
    {
        if (skillCounts >= 3)
            skillPanel.SetActive(false);
        Turn();
    }
    IEnumerator Turn() //턴도입 함수. 2초마다 플레이어와 상대의 턴이 돌아오면서 카드를 실행한다
    {
        if(playerTurn)
        {
            Debug.Log("Player의 턴");
            playerTurn = false;
        }
        else
        {
            Debug.Log("상대의 턴");
            playerTurn = true;
        }

        yield return new WaitForSeconds(2.0f);

    }
}
