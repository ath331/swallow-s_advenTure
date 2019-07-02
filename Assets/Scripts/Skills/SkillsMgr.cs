using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SkillsMgr : MonoBehaviour
{
    //##############스킬들의 정보를 저장하는 스크립트(나중에 디비로 옮겨서 관리할 생각중)
    //스킬이 3개가 생성되면 랜덤으로 스킬들을 할당해야함
    //스킬이 할당되면 해당 스킬에 맞는 스크립트만 엑티브 트루

    public Sprite[] skillsImage;
    private string skillName;

    PlayerMgr playerMgr;
    GameMgr gameMgr;

    private void Start()
    {
        playerMgr = GameObject.Find("Player").GetComponent<PlayerMgr>();
        int skillNum = Random.Range(0, 3);
        this.GetComponent<Image>().sprite = skillsImage[skillNum];
    }

    public void OnMouseDown()
    {
        if (GameMgr.instance.skillCounts < 3)
        {
            Debug.Log("스킬 클릭");
            this.transform.position =
                playerMgr.playerSkills[GameMgr.instance.skillCounts].transform.position;
            Debug.Log("플레이어 스킬칸 " + (GameMgr.instance.skillCounts+1) + " 번째칸에 스킬할당");
            GameMgr.instance.skillCounts++;
        }
    }
}
