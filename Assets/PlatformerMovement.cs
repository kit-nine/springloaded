using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMovement : MonoBehaviour{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private bool isJumping = false;
    private Rigidbody2D rb;
    // start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }
    // update is called once per frame
    void Update(){
        // horizontal movement
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 moveVector = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        // player jumping
        if(Input.GetButtonDown("Jump") && !isJumping){
            moveVector.y = jumpForce;
            isJumping = true;
        }
        rb.velocity = moveVector;
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Ground")){
            isJumping = false;
        }
    }
}