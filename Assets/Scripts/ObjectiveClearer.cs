using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveClearer : MonoBehaviour
{
    public GameObject objective;
	public AudioSource clearMusic;
	
	void Start() {
		clearMusic = GetComponent<AudioSource>();
	}
	
	public void ClearObjective() {
		objective.SetActive(false);
		clearMusic.Play();
	}
}
