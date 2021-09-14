using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float moveSpeed;
    SpriteRenderer playerSP;

    private void Awake(){
        playerRB = GetComponent<Rigidbody2D>();
        playerSP = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x < Screen.width / 2)
            {
                //Move Left
                playerRB.velocity = Vector2.left * moveSpeed;
                playerSP.flipX = true;
            }
            else
            {
                //Move Right
                playerRB.velocity = Vector2.right * moveSpeed;
                playerSP.flipX = false;
            }
        }
    }
}
