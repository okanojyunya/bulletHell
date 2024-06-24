using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//プレイヤーの弾のスクリプト
public class Bullet : MonoBehaviour
{
    
    /// <summary>発射する速度</summary>
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
        //敵にぶつかったら自分自身を破棄する

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
        //敵の弾にぶつかったら自分自信を破棄する
        if (collision.gameObject.tag == "EnemyBullet")
        {
             Destroy(this.gameObject);
        }

        
    }

}
