using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coni : MonoBehaviour {
    public  int playerScore = 0;
    public TextMesh scoreLabel;
 // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            playerScore++;
            
            scoreLabel.text = "Score: " + playerScore;
            Destroy(collision.gameObject);

        }
    }
}
