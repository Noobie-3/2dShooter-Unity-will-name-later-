using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Player : MonoBehaviour
{

    GameObject Player;
    public float Speed;
    public GameObject ObjectLookedAt;
    Rigidbody2D RB;
    public Vector2 MoveDirection;
    bool FacingLeft = false;
    SpriteRenderer SR;
    Animator A;



    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        Speed = 10;
        Player = GameObject.FindWithTag("Player");
        SR = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        MoveDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

    }

    private void FixedUpdate() {
/*        // Flip sprite horizontally based on MoveDirection
        if(MoveDirection.x < 0 && !FacingLeft) {
            FacingLeft = true;
        }
        else if(MoveDirection.x > 0 && FacingLeft) {
            FacingLeft = false;
        }
        if(SR.flipX != FacingLeft) SR.flipX = FacingLeft;

        // Running animation
        if((MoveDirection.x != 0 || MoveDirection.y != 0) && !A.GetBool("isRunning")) A.SetBool("isRunning", true);
        else if(MoveDirection.x == 0 && MoveDirection.y == 0 && A.GetBool("isRunning")) A.SetBool("isRunning", false);*/

        RB.MovePosition(RB.position + MoveDirection * Speed * Time.deltaTime);
    }
}
