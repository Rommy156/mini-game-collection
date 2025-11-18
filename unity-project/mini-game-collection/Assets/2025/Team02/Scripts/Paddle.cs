using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float moveSpeed = 6f;
    public bool isLeftPaddle;

    private float defaultHeight;

    void Start()
    {
        defaultHeight = transform.localScale.y;
    }

    void Update()
    {
        if (isLeftPaddle)
        {
            if (Input.GetKey(KeyCode.W))
                transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.S))
                transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
                transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.DownArrow))
                transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }
    }

    public void SpeedBoost(float duration, float boostAmount)
    {
        StopAllCoroutines();
        StartCoroutine(SpeedBoostRoutine(duration, boostAmount));
    }

    IEnumerator SpeedBoostRoutine(float duration, float boost)
    {
        moveSpeed += boost;
        yield return new WaitForSeconds(duration);
        moveSpeed -= boost;
    }

    public void Enlarge(float duration, float enlargeAmount)
    {
        StopAllCoroutines();
        StartCoroutine(EnlargeRoutine(duration, enlargeAmount));
    }

    IEnumerator EnlargeRoutine(float duration, float amount)
    {
        transform.localScale = new Vector3(
            transform.localScale.x,
            transform.localScale.y + amount,
            transform.localScale.z
        );

        yield return new WaitForSeconds(duration);

        transform.localScale = new Vector3(
            transform.localScale.x,
            defaultHeight,
            transform.localScale.z
        );
    }
}
