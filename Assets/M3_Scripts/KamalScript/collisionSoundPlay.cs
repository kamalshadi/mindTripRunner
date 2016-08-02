using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class collisionSoundPlay : MonoBehaviour {
	GameObject popup;
	private timeManager gameTimer;
	AudioSource myaudio;
	Text popuptext;

	// Use this for initialization
	void Start () {
		gameTimer = GameObject.Find ("TimeManager").GetComponent<timeManager>();
		myaudio = GameObject.Find("ballAudio").GetComponent<AudioSource>();
		popup = GameObject.Find ("cannon").GetComponent<initialCannon> ().popup;

	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.CompareTag ("Player")) {
			myaudio.Play ();
			gameTimer.timeLeft -= gameTimer.penalty;
			GameObject A = Instantiate (popup);
			popuptext = A.transform.GetChild(0).gameObject.GetComponent<Text> ();
			popuptext.text = string.Concat("-" ,gameTimer.penalty.ToString ());
			popuptext.color = Color.red;
		}
		Destroy (this.gameObject,1);
	}
	// Update is called once per frame
	void Update () {

	}
}
