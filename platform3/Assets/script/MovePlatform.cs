using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour {
    public float min;
    public float max;
    public string direction;
  

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, 3), transform.position.z);
        //  gameObject.transform.position = new Vector3( Mathf.Lerp(transform.position.x, transform.position.x+ 3, Mathf.PingPong(Time.time, 1)), transform.position.y, transform.position.z);
      //  transform.position = new Vector3(0, Mathf.Lerp(-1, 1, Mathf.PingPong(Time.time, 3f)), 0);
      if(direction=="horizontal")
            transform.position = new Vector3( Mathf.PingPong(Time.time, max-min)+min, transform.position.y, transform.position.z);
       
      if (direction=="vertical")
            transform.position = new Vector3(transform.position.x,Mathf.PingPong(Time.time, max - min) + min, transform.position.z);

    }
    

}
