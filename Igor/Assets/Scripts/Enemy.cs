using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 0.003f;
    public Vector3[] positions;
    private int index;
    private SpriteRenderer sr;
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
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

    }
    
}
