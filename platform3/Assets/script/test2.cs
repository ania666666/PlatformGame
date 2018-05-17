using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test2 : MonoBehaviour {
    public GameObject[] hearts;
    public GameObject panel;
    private int health;
    public string level;
    // Use this for initialization
    void Start()
    {
        health = hearts.Length;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")//tag przeszkód
        {
            health--;
            hearts[health].SetActive(false);
            //lub podmiana obrazka!
        }
        if (health == 0)
        {
            panel.SetActive(true);
         /*   if (level == "1")
                SceneManager.LoadScene("sc1");
            if (level == "2")
                SceneManager.LoadScene("sc2");*/

        }
    }
    public void LoadOnClick(int nrAction)
    {
        switch (nrAction)
        {
            case (0):
                if(level=="1")
                    SceneManager.LoadScene("sc1");
                if (level == "2")
                    SceneManager.LoadScene("sc2");
                break;
            case (1):
                Application.Quit();
                break;
            default:
                break;
        }
       
    }
}
