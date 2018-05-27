using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

	public float m_speed;

	void Start(){
		m_speed = -5f;
	}

	void Update () {
		// 移動_
		this.gameObject.transform.localPosition += new Vector3(m_speed, 0, 0);

		// TODO:画面端に行ったらDestoryする_

	}

}
