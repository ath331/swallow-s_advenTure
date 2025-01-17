﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMgr : MonoBehaviour
{
    public GameObject[] playerSkillsPosition; 
    //플레이어가 고른 스킬들을 플레이어 자식으로 할당하기위해 위치를 정해주는 오브젝트 저장
    
    public GameObject[] playersSkill;
    //할당이 끝나면 사용을 위해 해당위치에있는 스킬들을 배열에 넣는다.
    
    [HideInInspector] public float playerHP;
    [HideInInspector] public float playerEnergy;

    public Image HpBar;
    public Image EnergyBar;

    public GameObject firePos;
    public GameObject bull;

    private void Start()
    {
        playerHP = 100.0f;
        playerEnergy = 100.0f;
    }

    private void Update()
    {
        EnergyBar.fillAmount = (float)playerEnergy / (float) 100.0f;
        HpBar.fillAmount = (float)playerHP / (float)100.0f;
    }

    public void playerHPMinus( float _num )
    {
        playerHP -= _num;
    }

    public void playerEnergyMinus( float _num)
    {
        Debug.Log("Energy -10");
        playerEnergy -= _num;
    }
}
