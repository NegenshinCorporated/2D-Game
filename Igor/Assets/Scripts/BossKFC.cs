using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossKFC : MonoBehaviour
{
    private float speed = 0.003f;
    public Vector3[] positions;
    private int index;
    private SpriteRenderer sr;
    public Slider slider;
    private float health = 1000;
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        slider.value = health;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, positions[index], speed);
        if (transform.position == positions[index])
        {
            if (index < positions.Length - 1)
            {
                index++;
                sr.flipX = false;
            }
            else
            {
                index = 0;
                sr.flipX = true;
            }
        }
        if(slider.value == 0)
        {
            Destroy(gameObject);
        }
    }
    public void TakeDamage()
    {
        slider.value -= Random.Range(30, 80);
    }
}
