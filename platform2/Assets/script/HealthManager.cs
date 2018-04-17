using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour {

    public GameObject[] hearts;
    private int health;
    public string level;
	// Use this for initialization
	void Start () {
        health = hearts.Length;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag== "Enemy")//tag przeszkód
        {
            health--;
            hearts[health].SetActive(false);
            //lub podmiana obrazka!
        }
        if(health==0)
        {

            if(level=="1")
                SceneManager.LoadScene("sc1");
            if(level=="2")
                SceneManager.LoadScene("sc2");

        }
    }
}
