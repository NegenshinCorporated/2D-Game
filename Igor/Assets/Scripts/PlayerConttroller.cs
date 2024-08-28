using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConttroller : MonoBehaviour
{
    private float speed = 10f;
    private float force = 6f;
    private float horizontal;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private bool onIsland;
    public Transform islandCheck;
    public LayerMask whatIsIsland;
    public float radiusIslandCheck;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        onIsland = Physics2D.OverlapCircle(islandCheck.position, radiusIslandCheck, whatIsIsland);

        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * speed * Time.deltaTime * horizontal);
        sr.flipX = horizontal < 0;
        if (Input.GetKeyDown(KeyCode.W) && onIsland)
        {
            rb.AddForce(Vector2.up * force,ForceMode2D.Impulse);
            
        }
    }
}
