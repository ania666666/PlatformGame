using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    public float enemySpeed;
    private float moveXDirection=1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveXDirection * enemySpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            FlipEnemy();
        }
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