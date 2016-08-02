using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timePill : MonoBehaviour {
	public GameObject popup;
	private timeManager gameTimer;
	AudioSource myaudio;
	private GameObject mylight;
	Text popuptext;

	// Use this for initialization
	void Start () {
		gameTimer = GameObject.Find ("TimeManager").GetComponent<timeManager>();
		myaudio = GameObject.Find("pillAudio").GetComponent<AudioSource>();
		mylight = GameObject.Find ("pillLight");
	
	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.CompareTag ("Player")) {
			gameTimer.timeLeft += gameTimer.bonus;
		}
		myaudio.Play();
		Destroy (this.gameObject);
		GameObject A = Instantiate (popup);
		popuptext = A.transform.GetChild(0).gameObject.GetComponent<Text> ();
		popuptext.text = string.Concat("+" ,gameTimer.bonus.ToString ());
		popuptext.color = Color.green;
		Destroy (mylight);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
