using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�v���C���[�̒e�̃X�N���v�g
public class Bullet : MonoBehaviour
{
    
    /// <summary>���˂��鑬�x</summary>
    [SerializeField] float speed = 15;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;  
    }

    private void OnBecameInvisible()
    {
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�G�ɂԂ������玩�����g��j������

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
        //�G�̒e�ɂԂ������玩�����M��j������
        if (collision.gameObject.tag == "EnemyBullet")
        {
             Destroy(this.gameObject);
        }

        
    }

}
