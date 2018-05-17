using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public int playerSpeed = 10;
    private bool facingRight = false;
	public int playerJumpPower=1250;//mozna zmienić na float
	public float moveX;
    public bool isGrounded=false;
    private Animator animator;
    public Transform muzzle;
    public GameObject bomb;

    void Awake()
    {
        animator = GetComponent<Animator>();
     
    }

    // Use this for initialization
    void Update () {
        animator.SetBool("isGrounded", isGrounded);
        PlayerMove ();
	}
	void PlayerMove()
	{
		moveX = Input.GetAxis ("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(moveX));
        if (Input.GetButtonDown ("Jump")&&isGrounded==true) {
			Jump ();
            isGrounded = false;
            // moveX = Input.GetAxis("Horizontal");
        }
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bombs = Instantiate(bomb, muzzle.position, muzzle.rotation);
           
        }
        if ((moveX > 0.0f && facingRight == true)||(moveX < 0.0f && facingRight == false) ){
			FlipPlayer();
		}
	
		gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D> ().velocity.y);
		
	}
	void Jump()
	{
		GetComponent<Rigidbody2D> ().AddForce (Vector2.up * playerJumpPower);
        isGrounded = false;
    }
    void FlipPlayer()
	{
		facingRight = !facingRight;
		Vector2 localScale = gameObject.transform.localScale;
		localScale.x *= -1;
		transform.localScale = localScale;
	}
     private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject);
        if(collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Obstacle")
        {
            isGrounded = true;
        }

    }


}