using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    public bool right = false;
    public bool started = false;
    public Rigidbody2D body;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
       if (transform.position.x < 0)
        {
            right = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (started)
        {
            // Add logic for despawn
            if (right)
            {
                if (transform.position.x >= 12)
                {
                    Destroy(gameObject);
                }
            }
            else
            {
                if (transform.position.x <= -12)
                {
                    Destroy(gameObject);
                }
            }
            return;
        }
        speed = Random.Range(3, 6);

        if (!right)
        {
            spriteRenderer.flipX = true;
            body.velocity = Vector2.left * speed;

        }
        else
        {
            body.velocity = Vector2.right * speed;
        }
        started = true;
    }
}
