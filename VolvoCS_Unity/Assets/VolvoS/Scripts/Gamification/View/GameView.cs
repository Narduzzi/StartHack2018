using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TeamAVA.VolvoS.Gamification.Business;

namespace TeamAVA.VolvoS.Gamification.View {


	public class GameView : MonoBehaviour {

		[SerializeField] private RewardsPanel m_RewardsPanel;
		[SerializeField] private LevelSlider m_LevelSlider; 

		// Use this for initialization
		void Start () {
			
		}

		public RewardsPanel RewardsPanel {
			get {
				return this.m_RewardsPanel;
			}
		}

		public LevelSlider LevelSlider {
			get {
				return this.m_LevelSlider;
			}
		}


	}
}
