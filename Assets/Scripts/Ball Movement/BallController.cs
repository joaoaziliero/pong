using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameManager gameManager;

    private Rigidbody2D _rb;
    [SerializeField] private Vector2 _initialVelocity = new Vector2(5, 5);

    public void ResetBall()
    {
        transform.position = Vector3.zero;

        if (_rb == null) _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = _initialVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "TopWall":
                _rb.velocity = new Vector2(_rb.velocity.normalized.x * _initialVelocity.x,
                    (-1) * _initialVelocity.y);
                break;
            case "BottomWall":
                _rb.velocity = new Vector2(_rb.velocity.normalized.x * _initialVelocity.x,
                    (+1) * _initialVelocity.y);
                break;
            case "Player":
                _rb.velocity = new Vector2((-1) * _initialVelocity.x,
                    _initialVelocity.y);
                break;
            case "Enemy":
                _rb.velocity = new Vector2((+1) * _initialVelocity.x,
                    _initialVelocity.y);
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "EnemyWall":
                gameManager.ScorePlayer();
                ResetBall();
                break;
            case "PlayerWall":
                gameManager.ScoreEnemy();
                ResetBall();
                break;
        }
    }
}
