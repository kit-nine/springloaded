// kit seigler <3

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour{
    private Rigidbody2D rb;
    public float moveSpeed = 5.0f;
    // start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }
    // update is called once per frame
    void Update(){
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(horizontalInput, verticalInput) * moveSpeed;
    }
}
