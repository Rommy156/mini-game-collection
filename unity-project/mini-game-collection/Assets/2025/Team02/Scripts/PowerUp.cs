using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PowerUpType { SlowBall, BigPaddle, SpeedPaddle }

public class PowerUp : MonoBehaviour
{
    public PowerUpType type;
    public float duration = 4f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Paddle")) return;

        Paddle paddle = other.GetComponent<Paddle>();
        Ball ball = FindObjectOfType<Ball>();

        if (type == PowerUpType.SlowBall)
            ball.SlowBall(duration);

        if (type == PowerUpType.BigPaddle)
            paddle.Enlarge(duration, 1.5f);

        if (type == PowerUpType.SpeedPaddle)
            paddle.SpeedBoost(duration, 3f);

        Destroy(gameObject);
    }
}
