using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDamage : MonoBehaviour
{
    public GameObject m_HpBarPrefab;
    public Vector3 m_HpBarOffset = new Vector3(0, 2.2f, 0);
    private Canvas m_UiCanvas;
    private Image m_HpBarImage;

    public isCollision m_isCollision;

    public Player m_Player;

    private void Start()
    {
        SetHpBar();
    }

    void SetHpBar()
    {
        m_UiCanvas = GameObject.Find("UI Canvas").GetComponent<Canvas>();
        GameObject GetHpBar = Instantiate<GameObject>(m_HpBarPrefab, m_UiCanvas.transform);
        m_HpBarImage = GetHpBar.GetComponentsInChildren<Image>()[1];

        HpBar CharacterHpBarComponent = GetHpBar.GetComponent<HpBar>();
        CharacterHpBarComponent.m_TargetTransform = this.gameObject.transform;
        CharacterHpBarComponent.m_Offset = m_HpBarOffset;
    }

    private void OnCollisionEnter(Collision collision)
    {


        /*isCollision SnowBall = collision.collider.GetComponent<isCollision>();

        m_Player.m_Hp -= SnowBall.m_SnowBallDamage;
        print("¥Íæ“¿‹æ∆");
        print(m_Player.m_Hp);
        m_HpBarImage.fillAmount = m_Player.m_Hp / m_Player.m_InitHp;

        if (m_Player != null && m_Player.m_Hp <= 0)
        {

            print("µ⁄†∫¿Ω");
            m_Player.Dead();

        }
        */
    }

}
