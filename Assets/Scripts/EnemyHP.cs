using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;
using UnityEngine.UI;
//敵のHPのスクリプト
public class EnemyHP : MonoBehaviour
{
    public Slider HP;
    /// <summary>敵のHPの変数</summary>
    float m_enemyHp = 10;

    float Hp;

    private void Start()
    {
        HP.value = 10;
        Hp = m_enemyHp;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="Bullet")
        {

            //m_enemyHp -= 1;
            Hp -= 1;
            HP.value = (float)Hp;
           
        }

        if (Hp == 0)
        {
            Destroy(this.gameObject);
            Destroy(HP);
        }

    }

}
