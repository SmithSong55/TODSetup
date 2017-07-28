using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Animator animator;
	public float Speed = 10;

	// Update is called once per frame
	void Update () {
		//print ("x = "+  transform.position.x +" y = "+ transform.position.y);
		if (Input.GetKey(KeyCode.LeftArrow )) {
			animator.SetBool ("Walking", true);
			if(lefttrue())
				transform.Translate (Vector3.right * Time.deltaTime * Speed);
			transform.rotation = Quaternion.Euler (0, 180, 0);
			if (Input.GetKey(KeyCode.UpArrow ))
			if(uptrue())
				transform.Translate (Vector3.up * Time.deltaTime * Speed);
			if (Input.GetKey(KeyCode.DownArrow))
			if(downtrue())
				transform.Translate (Vector3.down * Time.deltaTime * Speed);
		} 
		else if (Input.GetKey(KeyCode.RightArrow )) {
			animator.SetBool ("Walking", true);
			if(righttrue())
				transform.Translate (Vector3.right * Time.deltaTime * Speed);
			transform.rotation = Quaternion.Euler (0, 0, 0);
			if (Input.GetKey(KeyCode.UpArrow ))
			if(uptrue())
				transform.Translate (Vector3.up * Time.deltaTime * Speed);
			if (Input.GetKey(KeyCode.DownArrow))
			if(downtrue())
				transform.Translate (Vector3.down * Time.deltaTime * Speed);
		} 
		else if(Input.GetKey(KeyCode.UpArrow )) {
			animator.SetBool ("Walking", true);
			if(uptrue())
				transform.Translate (Vector3.up * Time.deltaTime * Speed);
		} 
		else if (Input.GetKey(KeyCode.DownArrow )) {
			animator.SetBool ("Walking", true);
			if(downtrue())
				transform.Translate (Vector3.down * Time.deltaTime * Speed);
		} 
		else {
			animator.SetBool("Walking",false);
			animator.SetTrigger("Idle");

		}

		if(Input.GetKeyDown(KeyCode.Z))
			animator.SetTrigger("Attacking1");
		if(Input.GetKeyDown(KeyCode.X))
			animator.SetTrigger("Attacking2");
		if(Input.GetKeyDown(KeyCode.C))
			animator.SetTrigger("Utimate");
		if(Input.GetKeyDown(KeyCode.F))
			animator.SetTrigger("Win");
		if(Input.GetKeyDown(KeyCode.LeftShift))
			animator.SetTrigger("Dash");
		if(Input.GetKeyDown(KeyCode.Space))
			animator.SetTrigger("Jump");
			
	}

	bool uptrue(){
		if ((transform.position.y < -8.025 && transform.position.x > -8.190 -2 && transform.position.x < 14.567 +2) ||
			(transform.position.y < -7.670 && transform.position.x > 140.128 -2 && transform.position.x < 164.076 +2) ||
			(transform.position.y < -1.377 && transform.position.x >= 14.567 -2 && transform.position.x <= 140.128 +2))
			return true;
		return false;
	}

	bool downtrue(){
		if((transform.position.y > -19.161 && transform.position.x > 140.128 -2 && transform.position.x < 164.076 +2) || 
			(transform.position.y > -24.995 && transform.position.x > -8.190 -2 && transform.position.x <= 140.128 +2))
			return true;
		return false;
	}

	bool lefttrue(){
		if((transform.position.x > 14.567 && transform.position.y > -8.025 -2 && transform.position.y < -1.377 +2) || 
			(transform.position.x > -8.190 && transform.position.y > -24.995 -2 && transform.position.y <= -8.025 +2))
			return true;
		return false;
	}

	bool righttrue(){
		if((transform.position.x < 140.128 && transform.position.y > -24.995 -2 && transform.position.y < -1.377 +2) || 
			(transform.position.x < 164.076 && transform.position.y >= -19.961 -2 && transform.position.y <= -7.670 +2))
			return true;
		return false;
	}
}

