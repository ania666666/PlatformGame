using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthControler : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    const float TIME_TO_RESTART = 0.2f;
    public float LEVEL_1_X = -6f;
    public float LEVEL_1_Y = -2;
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(FellRload(collision));
        }
    }
    IEnumerator FellRload(Collision2D collision)
    {
        yield return new WaitForSeconds(TIME_TO_RESTART);
        collision.transform.position = new Vector2(LEVEL_1_X, LEVEL_1_Y);
     

    }
}
