using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    public float enemySpeed;
    private float moveXDirection=1;
    public bool isDead = false;
    private Animator animator;
    // Use this for initialization
    void Awake()
    {
        animator = GetComponent<Animator>();

    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        animator.SetBool("isDead", isDead);
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveXDirection * enemySpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            FlipEnemy();
        }

        if (collision.gameObject.tag == "Bomb")
        {
            isDead = true;
            StartCoroutine(FellRload(collision));
  
           //  Destroy(gameObject);
        }


    }
  
    IEnumerator FellRload(Collision2D collision)
{
    yield return new WaitForSeconds(1f);

        Destroy(gameObject);
    }
void FlipEnemy()
    {
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
        if (moveXDirection > 0)
        {
            moveXDirection = -1;
        }
        else
        {
            moveXDirection = 1;
        }
    }
 }