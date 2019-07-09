using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnermyMgr : MonoBehaviour
{
    [HideInInspector]
    public float enermyHP;
    public Image HpBar;

    // Start is called before the first frame update
    void Start()
    {
        enermyHP = 100.0f;
    }

    // Update is called once per frame
    void Update()
    {
        HpBar.fillAmount = (float)enermyHP / (float)100.0f;
    }

    public void EnermyHPMinus(float _num)
    {
        enermyHP -= _num;
    }

    public void EnermyMove()
    {
        int num = Random.Range(0, 4);
        Debug.Log("Move발동");
        if (num == 0)//Up
        {
            if (this.gameObject.transform.position.y + 2.2f <= 3.0f)
            {
                this.gameObject.transform.position 
                    = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y + 2.2f);
            }
        }
        else if (num == 1)//Down
        {
            if (this.gameObject.transform.position.y - 2.2f >= -3.0f)
            {
                this.gameObject.transform.position 
                    = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 2.2f);
            }
        }
        else if (num == 3)// >
        {
            if (this.gameObject.transform.position.x + 4.0f <= 7.0f)
            {
                this.gameObject.transform.position 
                    = new Vector2(this.gameObject.transform.position.x + 4.0f, this.gameObject.transform.position.y);
            }
        }
        else if (num == 2)// <
        {
            if (this.gameObject.transform.position.x - 4.0f >= -10.0f)
            {
                this.gameObject.transform.position 
                    = new Vector2(this.gameObject.transform.position.x - 4.0f, this.gameObject.transform.position.y);
            }
        }
        //애니메이션 추가

}
}
