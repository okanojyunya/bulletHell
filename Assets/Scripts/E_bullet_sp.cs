using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_bullet_sp : MonoBehaviour
{
     float angle;//角度
     float speed;//速度
    Vector3 velocity;//移動量
    void Start()
    {
        //x,y方向の移動量の設定
        velocity.x = speed * Mathf.Cos(angle * Mathf.Deg2Rad);
        velocity.y = speed * Mathf.Sin(angle * Mathf.Deg2Rad);

        float zAngle = Mathf.Atan2(velocity.y, velocity.x) * Mathf.Rad2Deg - 90.0f;
        transform.rotation = Quaternion.Euler(0, 0, zAngle);
    }
    //カメラ外に行くと消える
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
