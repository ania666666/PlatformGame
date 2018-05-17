using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeController : MonoBehaviour {
    public float volue = 0.5f;
    public float minVolume = 0.0f;
    public float maxVolume = 1.0f;

    private AudioSource audio;
    // Use this for initialization
    void Start () {
        audio = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        audio.volume = volue;
	}
    private void OnGUI()
    {
        GUI.Label(new Rect(150, 0, 100, 30), "Volume");
        volue = GUI.HorizontalSlider(new Rect(150, 30, 100, 30), volue, minVolume, maxVolume);
    }
}
