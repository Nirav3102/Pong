using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    ball Ball;

    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject player1Text;
    public GameObject player2Text;

    private int player1Score;
    private int player2Score;
    
    public void Player1Scored()
    {
        player1Score++;
        player1Text.GetComponent<TextMeshProUGUI>().text = player1Score.ToString();
        ResetPosition();
    }
    public void Player2Scored()
    {
        player2Score++;
        player2Text.GetComponent<TextMeshProUGUI>().text = player2Score.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        Ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<ball>();
        Ball.Reset();
        player1Paddle.GetComponent<paddle>().Reset();
        player2Paddle.GetComponent<paddle>().Reset();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
