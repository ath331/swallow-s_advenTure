using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMgr : MonoBehaviour
{
    public GameObject[] playerSkills; 
    //플레이어가 고른 스킬들을 플레이어 자식으로 할당하기위해 위치를 정해주는 오브젝트 저장
    //private GameObject[] playersSkill;
    //할당이 끝나면 사용을 위해 해당위치에있는 스킬들을 배열에 넣는다.

    private void Awake()
    {
    }
}
