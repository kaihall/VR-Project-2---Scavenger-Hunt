using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetDoorAnimator : MonoBehaviour
{
    private bool closed = true;
	public GameObject cabinet;
	
	public void ChangeState() {
		if (closed) {
			closed = false;
			cabinet.GetComponent<Animator>().Play("Base Layer.KS_Open");
		} else {
			closed = true;
			cabinet.GetComponent<Animator>().Play("Base Layer.KS_Close");
		}
	}
}
