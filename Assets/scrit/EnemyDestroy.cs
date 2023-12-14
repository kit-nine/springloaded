using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour {
    private Animator enemyAnimator;
    public Rigidbody2D rb;
    public float bounce;
    void Start() {
        enemyAnimator = transform.parent.GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player"){
            rb.velocity = new Vector2(rb.velocity.x, bounce);
            enemyAnimator.SetTrigger("Destroy");
            Invoke("DestroyEnemy", 0.5f);
        }
    }
    public void DestroyEnemy() {
        Destroy(transform.parent.gameObject);
    }
}
