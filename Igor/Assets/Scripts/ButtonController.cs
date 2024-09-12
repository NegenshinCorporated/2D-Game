using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void Respawn()
    {
        SceneManager.LoadScene(0);
    }
    public void NextLevel()
    {
        Debug.Log("Всё чиназес");
    }
}
