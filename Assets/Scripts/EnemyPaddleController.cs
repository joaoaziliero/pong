using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPaddleController : MonoBehaviour
{
    public GameObject ball;
    public float speed = 3;

    private void Update()
    {
        var targetY = Mathf.Clamp(ball.transform.position.y, -4.5f, 4.5f);
        var targetPosition = new Vector2(transform.position.x, targetY);
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
}
