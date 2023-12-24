using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform playerPaddle;
    public Transform enemyPaddle;
    public BallController ball;

    public int playerScore = 0;
    public int enemyScore = 0;

    private void Start()
    {
        ResetGame();
    }

    public void ResetGame()
    {
        enemyPaddle.position = new Vector3(-7, 0, 0);
        playerPaddle.position = new Vector3(7, 0, 0);
        ball.ResetBall();
    }
}
