using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {
 
	public float bombSpeed;
    public PlayerController player;
    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
        if(player.transform.localScale.x>0)
        {
            bombSpeed = -bombSpeed;
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        Destroy(gameObject, 4f);
    }
    private void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(bombSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject);
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Obstacle"|| collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
       
    }
}
