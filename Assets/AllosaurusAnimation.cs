using UnityEngine;
using System.Collections;

public class AllosaurusAnimation : MonoBehaviour
{

	Animation anim;
	AudioSource audio;

	IEnumerator Start ()
	{
		anim = GetComponent<Animation> ();
		audio = GetComponent<AudioSource> ();
		yield return new WaitForSeconds (anim.clip.length);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) {
			anim.Play ("Allosaurus_IdleBellow");
			audio.PlayDelayed (1.5f);
		}
	}
}
