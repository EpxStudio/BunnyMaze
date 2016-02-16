﻿using UnityEngine;
using System.Collections;

public class EatBunnyWall : MonoBehaviour
{
    public GameObject AudApproach;
    public GameObject AudEaten;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
        if (AudApproach.GetComponent<AudioSource>().volume != 1)
            AudApproach.GetComponent<AudioSource>().volume += 0.01F;
	}

	

    void OnTriggerEnter(Collider C)
    {
        AudApproach.GetComponent<AudioSource>().volume = 0F;
    	Global.ShowEatBunny = true;
        AudApproach.GetComponent<AudioSource>().Play();
        AudApproach.GetComponent<AudioSource>().volume = 0F;
    }

    bool EatenHasPlayed = false;

    void OnGUI()
    {
    	if (Global.ShowEatBunny)
    	{
    		GUI.Label(new Rect((Screen.width/2 - 210), Screen.height/2, (Screen.width/2 + 210), Screen.height/2), "You're hungry. If only there were a giant chocolate bunny you could eat...");
    	}
    	else if (Global.canOpenGates && !EatenHasPlayed)
    	{
    		AudApproach.GetComponent<AudioSource>().Stop();
            AudEaten.GetComponent<AudioSource>().Play();
            EatenHasPlayed = true;
    	}
    }
}
