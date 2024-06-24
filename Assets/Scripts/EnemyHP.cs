using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//敵のHPのスクリプト
public class EnemyHP : MonoBehaviour
{
    /// <summary>敵のHPの変数</summary>
    [SerializeField] float m_enemyHp = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="Bullet")
        {
            m_enemyHp -= 1;
        }

        if (m_enemyHp == 0)
        {
            Destroy(this.gameObject);
        }

    }

}
