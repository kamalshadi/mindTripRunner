﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameOverScript : MonoBehaviour {
	AudioSource myaudio;
	public KayaIsoLocomotion playerS;
	private AudioSource[] allAudioSources;
	private bool fg =true;
	private timeManager tm;
	// Use this for initialization
	void Start () {
		tm = GameObject.Find ("TimeManager").GetComponent<timeManager> ();
		myaudio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerS.ragDoll && fg) {
			fg = false;
			StopAllAudio ();
			myaudio.Play ();
		}
		if (tm.timeLeft < .01 && fg) {
			fg = false;
			StopAllAudio ();
			myaudio.Play ();
		}
		if (!fg && !myaudio.isPlaying) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	
	}

	void StopAllAudio() {
		allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
		foreach( AudioSource audioS in allAudioSources) {
			audioS.Stop();
		}
}
}
