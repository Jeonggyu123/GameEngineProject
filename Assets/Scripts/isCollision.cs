using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class isCollision : MonoBehaviour
{
    public int m_SnowBallDamage;

    private void OnCollisionEnter(Collision collision)
    {
        Player player = collision.collider.GetComponent<Player>();

        
        print("¥Íæ“¿‹æ∆");

        if(player != null)
        {
            player.GetDamage(m_SnowBallDamage);
            print(player.m_CurHp);
            if(player.m_CurHp <= 0)
            {
                player.Dead();
            }
                
        }
       
        
    }
    
}
