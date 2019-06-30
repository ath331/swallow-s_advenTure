using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    public static GameMgr instance = null;
    public GameObject player;

    public Transform[] floors;//Stage의 Floor들을 배열로 받기위한 변수
    public Transform[] skills;//skill들을 저장하기 위한 변수


    private void Awake()
    {
        instance = this;
        Debug.Log("게임매니저 스크립트을 싱글턴화");
    }

    void Start()
    {
        floors = GameObject.Find("Stage").GetComponentsInChildren<Transform>();
        skills = GameObject.Find("SkillPanel").GetComponentsInChildren<Transform>();
        player.transform.position = floors[5].transform.position; //Player위치를 배열5번칸 (2행1열)로 배치
        Debug.Log("Plater위치 할당");
    }
    
    void Update()
    {
        
    }
}
