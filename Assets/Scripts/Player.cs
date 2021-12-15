using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float m_fSpeed = 1.0f;

    public float m_CurHp;

    public float m_InitHp;

    public GameObject m_HpBar;

    public event UnityAction<float> m_OnCurrentHeight;

    public event UnityAction<int> m_OnTimer;

    public GameObject m_PrefabDamageText;

    public GameObject m_TextPos;//생성될 위치를 잡아줌

    private float m_Float;

    public void GetDamage(int damage)
    {
        GameObject dmgText = Instantiate(m_PrefabDamageText, m_TextPos.transform.position, Quaternion.identity);
        dmgText.GetComponent<Text>().text = damage.ToString();
        m_CurHp -= damage;
        m_HpBar.GetComponent<Image>().fillAmount = m_CurHp / m_InitHp; 

        Destroy(dmgText, 0.3f);

    }

    private void Start()
    {
        CurrentHeight();
    }

    void CurrentHeight()
    {
        float PostionY = transform.position.y;
        m_OnCurrentHeight.Invoke(PostionY);
    }


    void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var vericalInput = Input.GetAxis("Vertical");
        var vec = new Vector3(horizontalInput, 0, vericalInput).normalized;

        transform.rotation = Quaternion.LookRotation(vec);
        transform.Translate(vec * (Time.deltaTime * m_fSpeed), Space.World);


    }

    public void Dead()
    {
        gameObject.SetActive(false);

    }

  

}
