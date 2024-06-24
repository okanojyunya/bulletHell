using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartChang : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("InGame Scene");
        }
    }
    public void restart_button()
    {
        SceneManager.LoadScene("Start Scene");

    }
}
