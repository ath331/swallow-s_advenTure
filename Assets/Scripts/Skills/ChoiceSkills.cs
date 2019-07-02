using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChoiceSkills : MonoBehaviour
{
    public Transform[] skillSetting;//스킬 이미지가 뜨는위치 저장변수
    public GameObject skillPrefab;
    private Transform parent;


    private void Start()
    {
        parent = GameObject.Find("ChoicePanel").GetComponent<Transform>();
        for (int i = 0; i < 3; i++)
        {
            Instantiate(skillPrefab, skillSetting[i].position, skillSetting[i].rotation)
                .transform.parent = parent;

            Debug.Log(i + " 스킬 생성");
            //위의 생성된 스킬들을 랜덤으로 무슨 스킬인지 할당을 위한 변수
        }
    }
}
