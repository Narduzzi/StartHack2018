using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TeamAVA.VolvoS.Gamification;

public class GameController : MonoBehaviour {

	[SerializeField] private Mock m_Mock;   

	// Use this for initialization
	void Start () {
		m_Mock.CreateRewards ();
	}

}
