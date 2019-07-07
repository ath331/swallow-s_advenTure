using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMgr : MonoBehaviour
{
    public static GameMgr instance = null;
    public GameObject player;
    public GameObject enermy;
    public Image skillPanel;
    public int skillCounts = 0;

    int playerUse = 0;
    int enermyUse = 0;

    public GameObject GameSet;

    public Transform[] floors;//Stage의 Floor들을 배열로 받기위한 변수
    public bool gameStart = false;

    private bool playerTurn = true; //플레이어의 턴을 구별하기위한 변수
    public int turnCount = 1;


    ChoiceSkills choSkills;
    PlayerMgr playerMgr;

    private void Awake()
    {
        instance = this;
        Debug.Log("게임매니저 스크립트을 싱글턴화");
    }

    void Start()
    {
        choSkills = GameObject.Find("ChoicePanel").GetComponent<ChoiceSkills>();
        floors = GameObject.Find("Stage").GetComponentsInChildren<Transform>();
        playerMgr = GameObject.Find("Player").GetComponent<PlayerMgr>();

        player.transform.position = floors[5].transform.position; //Player위치를 배열5번칸 (2행1열)로 배치
        Debug.Log("Plater위치 할당");
        enermy.transform.position = floors[8].transform.position;
        Debug.Log("Enermy 할당");


    }
    private void Update()
    {
        if (playerMgr.playerHP <= 0)
        {
            CallGameSet();
        }
        if (gameStart == true)
        {
            Turn();
        }
    }

    private void Turn()
    {
        playerUse = 0;
        enermyUse = 0;
        while (choSkills._this.activeSelf == false && turnCount <= 6)
        {
            if (playerTurn)
            {
                Debug.Log(turnCount);
                Debug.Log("player turn");
                UseSkill();
                turnCount++;
                playerTurn = false;
            }

            else if (!playerTurn)
            {
                Debug.Log(turnCount);
                Debug.Log("enermy turn");
                UseSkill();
                turnCount++;
                playerTurn = true;
            }
            else if (turnCount == 6)
            {
                return;
            }

        }
        turnCount = 1;
        gameStart = false;
        choSkills._this.SetActive(true);

    }

    void UseSkill()
    {
        if (playerTurn)
        {
            Debug.Log("Player Use Skill!");
            if (playerMgr.playersSkill[playerUse].GetComponent<Image>().sprite.name.Equals("Skill1"))
            {
                Debug.Log("Player_Move");
                playerMgr.playersSkill[playerUse].GetComponent<Move>().PlayerMove();
                playerUse++;
                return;
            }
            else if (playerMgr.playersSkill[playerUse].GetComponent<Image>().sprite.name.Equals("Skill2"))
            {
                Debug.Log("Player_Offen");
                playerMgr.playersSkill[playerUse].GetComponent<Offensive>().PlayerOffensive();
                playerUse++;
                return;
            }
            else if (playerMgr.playersSkill[playerUse].GetComponent<Image>().sprite.name.Equals("Skill3"))
            {
                Debug.Log("Player_Defen");
                playerMgr.playersSkill[playerUse].GetComponent<Defensive>().PlayerDefensive();
                playerUse++;
                return;
            }
        }
        else if (!playerTurn)
        {
            Debug.Log("Enermy Use Skill!");
        }
    }

    void CallGameSet()
    {
        GameSet.SetActive(true);
        AudioListener.volume = 0;
    }
}
