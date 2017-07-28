using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaturePigAI : MonoBehaviour {

	public Animator animator;
	public int Hp;
	public float Speed;
	public float tm;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		tm -= Time.deltaTime;
		if (tm < 0 && !animator.GetBool("Damaged")) {
			animator.SetTrigger ("Run");
			if (transform.position.x > 160)
				transform.rotation = Quaternion.Euler (0, 0, 0);
			else if(transform.position.x < 0 )
				transform.rotation = Quaternion.Euler (0, 180, 0);


			transform.Translate (Vector3.left * Time.deltaTime * Speed);
		}
	}
}
