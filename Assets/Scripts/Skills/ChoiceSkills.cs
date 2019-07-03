using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChoiceSkills : MonoBehaviour
{
    public Transform[] skillSetting;//스킬 이미지가 뜨는위치 저장변수
    public GameObject skillPrefab;
    private Transform parent;
    public GameObject _this;

    private void Update()
    {
        if (GameMgr.instance.skillCounts >= 3)
            _this.SetActive(false);
    }

    private void OnEnable()
    {
        if (GameMgr.instance.skillCounts >= 3)
        {
            GameMgr.instance.skillCounts = 0;
        }

        parent = GameObject.Find("SkillPanel").GetComponent<Transform>();
        for (int i = 0; i < 3; i++)
        {
            Instantiate(skillPrefab, skillSetting[i].position, skillSetting[i].rotation).transform.SetParent(parent);

            Debug.Log(i + " 스킬 생성");
        }
    }
}
