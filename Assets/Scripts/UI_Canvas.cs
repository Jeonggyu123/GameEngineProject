using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Canvas : MonoBehaviour
{
    public Text m_TextCurrentHeightInfo;

    public Text m_TextTimer;

    public Player m_Player;

    private float m_Sec;

    private float m_Min;

    
    private void Update()
    {

        UpdateTextTimer();
        UpdateTextHeightInfo();

    }

    void UpdateTextHeightInfo()
    {
        string HeightFormat = string.Format("{0} m", (int)m_Player.transform.position.y);

        m_TextCurrentHeightInfo.text = HeightFormat;

    }

    void UpdateTextTimer()
    {

        m_Sec += Time.deltaTime;

        m_TextTimer.text = string.Format("{0}:{1}", m_Min, (int)m_Sec);

        if ((int)m_Sec > 59)
        {
            m_Sec = 0;
            m_Min++;

        }

    }

}
