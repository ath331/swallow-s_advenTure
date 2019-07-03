using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMgr : MonoBehaviour
{
    public static GameMgr instance = null;
    public GameObject player;
    public Image skillPanel;
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
        
    }
    
    //턴제 활용 함수추가 .activeSlef 활용
    //스킬을 다고른후 ( Choicepanel이 false일경우 플레이어의 턴 시작)
    //턴마다 첫번쨰 카드를 실행후 해당 카드 삭제 -> 다시 카드를 고를때 있으면 안되니깐
}
