using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TeamAVA.VolvoS.Gamification;
using TeamAVA.VolvoS.Gamification.View;

public class GameController : MonoBehaviour {

	[SerializeField] private VolvoSServices m_Services; 
	[SerializeField] private GameView m_GameView; 

	// Use this for initialization
	void Start () {
		Debug.Log ("Initialise App");
		m_Services = new VolvoSServices ();
		m_GameView.RewardsPanel.CreateRewardsButton (m_Services.AvailableRewards);
	}

}
