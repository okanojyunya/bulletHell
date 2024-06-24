using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//�v���C���[�̍s���̃X�N���v�g
public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>�X�s�[�h�̕ϐ� </summary>
    [SerializeField] float m_movePower = 5;
    /// <summary>��󂩁A����������ړ�����ϐ� </summary>
    float m_h;
    /// <summary>�����@���̕ϐ�</summary>
    Rigidbody2D m_rb = default;
    /// <summary>Bullet�v���n�u���擾����</summary>
    [SerializeField] GameObject m_bulletPrefab;
    /// <summary>�e���o�Ă���Ƃ�����w�肷��</summary>
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

