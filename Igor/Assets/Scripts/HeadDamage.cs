using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadDamage : MonoBehaviour
{
    public GameObject bossKFC;
    private BossKFC bk;
    private void Start()
    {
        bk = bossKFC.GetComponent<BossKFC>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            bk.TakeDamage();
        }
    }
}
