using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeDoorAnimator : MonoBehaviour
{
    private bool closed = true;
	public GameObject fridge;
	
	public void ChangeState() {
		if (closed) {
			closed = false;
			fridge.GetComponent<Animator>().Play("Base Layer.F_Open");
		} else {
			closed = true;
			fridge.GetComponent<Animator>().Play("Base Layer.F_Close");
		}
	}
}
