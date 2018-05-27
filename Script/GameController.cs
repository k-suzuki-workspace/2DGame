using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	[SerializeField]
	private GameObject m_blockObj;

	private float m_count;
	public float m_interval = 10f;


	void Update()
	{
		// 一定間隔ごとにブロックを生成する_
		m_count++;
		Debug.LogError("m_count = " + m_count);
		if(m_count > m_interval){
			Instantiate(m_blockObj, m_blockObj.transform);
			m_interval = 0;
		}
	}

}
