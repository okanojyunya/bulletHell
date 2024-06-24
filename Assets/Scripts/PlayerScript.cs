using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//プレイヤーの行動のスクリプト
public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>スピードの変数 </summary>
    [SerializeField] float m_movePower = 5;
    /// <summary>矢印か、を押したら移動する変数 </summary>
    float m_h;
    /// <summary>物理法則の変数</summary>
    Rigidbody2D m_rb = default;
    /// <summary>Bulletプレハブを取得する</summary>
    [SerializeField] GameObject m_bulletPrefab;
    /// <summary>弾が出てくるところを指定する</summary>
    [SerializeField] Transform m_muzzle = default;
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        m_h = Input.GetAxisRaw("Horizontal");

      m_rb.velocity = m_h * m_movePower * Vector2.right;
      //m_rb.AddForce(m_rb.velocity * m_movePower * Vector2.up.normalized);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<AudioSource>().Play();
            GameObject Player = Instantiate(m_bulletPrefab, m_muzzle.position, this.transform.rotation);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }


}

