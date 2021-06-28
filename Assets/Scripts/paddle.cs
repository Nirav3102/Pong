using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    float movement;
    public Vector3 startPosotion;

    // Start is called before the first frame update
    void Start()
    {
        startPosotion = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        rb.velocity = new Vector2(0, speed * movement);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosotion;
    }
}
