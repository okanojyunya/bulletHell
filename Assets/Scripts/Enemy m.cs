using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemym : MonoBehaviour
{
    private GameObject[] enemyObjects;
    void Update()
    {
        enemyObjects = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemyObjects.Length == 0)
        {
            SceneManager.LoadScene("Clear Scenes");
        }
    }
}
