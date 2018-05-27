using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour {

	[SerializeField]
	private Rigidbody2D m_rigidbody2D;

	public float jumpPower = 1200f;


	void Start () {
	}

	void Update () {
		bool isJump = Input.GetButtonDown("Jump");
		if(isJump){
			m_rigidbody2D.AddForce(Vector2.up * jumpPower);
			isJump = false;
		}
	}


}
