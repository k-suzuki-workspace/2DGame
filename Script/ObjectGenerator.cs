using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour {

	[SerializeField]
	private GameObject m_blockObj;

	private float m_count = 200f;
	public float m_interval = 200f;


	void Update()
	{
		// 一定間隔ごとにブロックを生成する_
		m_count++;
		if(m_count > m_interval){
			Instantiate(m_blockObj, this.transform);
			m_count = 0;
		}
	}

}
