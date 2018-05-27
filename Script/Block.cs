using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

	public float m_speed;
	private bool m_isGround;

	void Start(){
		Debug.LogError("start");
		this.gameObject.SetActive(true);
		m_speed = 5f;
		m_isGround = false;
	}

	void Update () {
		// 移動_
		if (m_isGround){
			this.gameObject.transform.localPosition += new Vector3(-m_speed, 0, 0);
		}
		// TODO:画面端に行ったらDestoryする_

	}


	void OnCollisionEnter2D(Collision2D collision){
		if(LayerMask.LayerToName(collision.gameObject.layer) == "Ground"){
			m_isGround = true;
			Debug.LogError("m_isGround = " + m_isGround);
		}
	}

	//void OnCollisionExit2D(Collision2D collision){
	//	if (LayerMask.LayerToName(collision.gameObject.layer) == "Ground"){
	//		m_isGround = false;
	//		Debug.LogError("m_isGround = " + m_isGround);
	//	}
	//}

}
