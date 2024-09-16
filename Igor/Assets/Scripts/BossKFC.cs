using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossKFC : MonoBehaviour
{
    private float speed = 0.003f;
    private Vector3[] positions;
    private int index;
    private SpriteRenderer sr;
    public Slider slider;
    private float health = 1000;
    private void Start()
    {
        positions = new Vector3[2] {new Vector3(108.17f, -3.43f, 0),new Vector3(95.8f, -3.43f, 0)};
        sr = GetComponent<SpriteRenderer>();
        slider.value = health;
    }

    void Update()
    {
        Move();
        if (slider.value == 0)
        {
            Destroy(gameObject);
        }
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, positions[index], speed);
        if (transform.position == positions[index])
        {
            if (index < positions.Length - 1)
            {
                index++;
                sr.flipX = true;
            }
            else
            {
                index = 0;
                sr.flipX = false;
            }
        }
    }

    public void TakeDamage()
    {
        slider.value -= Random.Range(30, 80);
    }
}
