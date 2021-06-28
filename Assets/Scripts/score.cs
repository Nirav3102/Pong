using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public bool isPlayer1Goal;
    GameManager extractGoal;

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if(otherCollider.gameObject.CompareTag("Ball"))
        {
            if(isPlayer1Goal)
            {
                Debug.Log("Player 2 scored!");
                extractGoal = GameObject.FindGameObjectWithTag("gm").GetComponent<GameManager>();
                extractGoal.Player2Scored();
            }
            else
            {
                Debug.Log("Player 1 scored!");
                extractGoal = GameObject.FindGameObjectWithTag("gm").GetComponent<GameManager>();
                extractGoal.Player1Scored();
            }
        }
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
