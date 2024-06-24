using System.Collections;
using System.Collections.Generic;
//using TMPro.EditorUtilities;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    float timeCount = 0;//ŽžŠÔŒo‰ß
    float shotAngle = 0;
   [SerializeField] float speed = 0;
   [SerializeField] GameObject shotBullet;//”­ŽË‚·‚é’e

    void Start()
    {

    }

    void Update()
    {
        timeCount += Time.deltaTime;
        
        if (timeCount > 0.1)
        {
            timeCount = 0;

           shotAngle += 20;
          GameObject createObject = Instantiate(shotBullet, transform.position, Quaternion.identity);

            E_bullet_sp E_bullet_sp = createObject.GetComponent<E_bullet_sp>();

            E_bullet_sp.Init(shotAngle, speed);
        }
    }
}
