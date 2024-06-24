using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_bullet_sp : MonoBehaviour
{
     float angle;//�p�x
     float speed;//���x
    Vector3 velocity;//�ړ���
    void Start()
    {
        //x,y�����̈ړ��ʂ̐ݒ�
        velocity.x = speed * Mathf.Cos(angle * Mathf.Deg2Rad);
        velocity.y = speed * Mathf.Sin(angle * Mathf.Deg2Rad);

        float zAngle = Mathf.Atan2(velocity.y, velocity.x) * Mathf.Rad2Deg - 90.0f;
        transform.rotation = Quaternion.Euler(0, 0, zAngle);
    }
    //�J�����O�ɍs���Ə�����
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        transform.position += velocity * Time.deltaTime;
    }

    public void Init(float input_angle, float input_speed)
    {
        angle = input_angle;
        speed = input_speed;
    }

   
}
