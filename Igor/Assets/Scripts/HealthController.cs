using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public Slider slider;
    private float health = 100;
    public GameObject sceneManager;
    private ScreenManager screenManager;
    public GameObject killBox;
    private void Start()
    {
        screenManager = sceneManager.GetComponent<ScreenManager>();
        slider.value = health;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("KillBox"))
        {
            health = 0;
            screenManager.Loose();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            slider.value -= 10;
            health = slider.value;
            if (health <= 0)
            {
                
            }
        }
        if (collision.gameObject.CompareTag("BossKFC"))
        {
            slider.value -= 20;
            health = slider.value;
        }
    }
}
