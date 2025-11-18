using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 7f;
    public float slowMultiplier = 0.5f;

    private Rigidbody2D rb;
    private Vector2 direction;
    private float defaultSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        defaultSpeed = speed;
        LaunchBall();
    }

    void LaunchBall()
    {
        int x = Random.Range(0, 2) == 0 ? -1 : 1;
        int y = Random.Range(-1, 2);
        direction = new Vector2(x, y).normalized;
        rb.velocity = direction * speed;
    }

    public void ResetBall()
    {
        rb.velocity = Vector2.zero;
        transform.position = Vector2.zero;
        speed = defaultSpeed;
        Invoke("LaunchBall", 1f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Wall"))
        {
            direction = Vector2.Reflect(direction, collision.contacts[0].normal).normalized;
            rb.velocity = direction * speed;
        }

        if (collision.collider.CompareTag("Paddle"))
        {
            float hitFactor = (transform.position.y - collision.transform.position.y)
                / collision.collider.bounds.size.y;

            direction = new Vector2(direction.x * -1, hitFactor).normalized;
            rb.velocity = direction * speed;
        }
    }

    public void SlowBall(float duration)
    {
        StopAllCoroutines();
        StartCoroutine(SlowRoutine(duration));
    }

    IEnumerator SlowRoutine(float duration)
    {
        speed *= slowMultiplier;
        rb.velocity = direction * speed;
        yield return new WaitForSeconds(duration);
        speed = defaultSpeed;
        rb.velocity = direction * speed;
    }
}
