using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitMonster : MonoBehaviour {
	void Start(){
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag ("Monster")) {
			NaturePigAI ai = other.GetComponent<NaturePigAI> ();
			//print ("Hit");
			ai.animator.SetTrigger("Damaged");
			ai.Speed += 0.5f;
			if(--ai.Hp == 0)
				other.gameObject.SetActive (false);
		}
		print(Display.displays[0].active);
	}

}
