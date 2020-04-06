using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour {

	public AudioSource Musuh1;
	public AudioSource Musuh2;
	public AudioSource Musuh3;
	public AudioSource Musuh4;
		
	// Use this for initialization
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "ObjectMusuh"){
			Debug.Log("Collide Musuh1!");
			Musuh1.GetComponent<AudioSource> ();
			Musuh1.Play ();
			col.gameObject.SetActive (false);
		}if (col.gameObject.tag == "ObjectMusuh2"){
			Debug.Log("Collide Musuh2!");
			Musuh2.GetComponent<AudioSource> ();
			Musuh2.Play ();
			col.gameObject.SetActive (false);
		}if (col.gameObject.tag == "ObjectMusuh3"){
			Debug.Log("Collide Musuh3!");
			Musuh3.GetComponent<AudioSource> ();
			Musuh3.Play ();
			col.gameObject.SetActive (false);
		}if (col.gameObject.tag == "ObjectMusuh4"){
			Debug.Log("Collide Musuh4!");
			Musuh4.GetComponent<AudioSource> ();
			Musuh4.Play ();
			col.gameObject.SetActive (false);
		}
	}
}
