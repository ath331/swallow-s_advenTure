using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChoiceSkills : MonoBehaviour
{
    public Transform[] skillSetting;//스킬 이미지가 뜨는위치 저장변수
    public GameObject skillPrefab;//뜨는 스킬 프리팹 생성이후 이미지가 랜덤으로 변환 -> 스킬사용시 이미지로 구별
    private Transform parent;


    private void Start()
    {
        parent = GameObject.Find("ChoicePanel").GetComponent<Transform>();
        for (int i = 0; i < 3; i++)
        {
            Instantiate(skillPrefab, skillSetting[i].position, skillSetting[i].rotation)
                .transform.parent = parent;

            Debug.Log(i + " 스킬 생성");
            int skillNum = Random.Range(1, 3);//위의 생성된 스킬들을 랜덤으로 무슨 스킬인지 할당을 위한 변수
            if( skillNum == 1)
            {

            }
        }
    }
}
