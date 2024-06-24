using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartChang : MonoBehaviour
{
    public void restart_button()
    {
        SceneManager.LoadScene("Start Scene");
        Debug.Log("リスタートボタンが認識しています");
    }
}
