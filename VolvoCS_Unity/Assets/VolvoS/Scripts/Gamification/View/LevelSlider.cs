using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TeamAVA.VolvoS.Gamification.Business;

namespace TeamAVA.VolvoS.Gamification.View {


	public class LevelSlider : MonoBehaviour {

		[SerializeField] private Slider m_Slider;
		[SerializeField] private Text m_Text;
		private Level m_Level;

		// Use this for initialization
		public void Initialize (Level level) {
			// CheckComponents ();
			m_Level = level;
			m_Text.text = m_Level.MaxPoint.ToString();
		}

		private void CheckComponents(){
			m_Slider = this.gameObject.GetComponent<Slider>();
			if(m_Slider == null) throw new MissingComponentException("No Button component found.");

			m_Text = this.gameObject.GetComponentInChildren<Text>();
			if(m_Text == null) throw new MissingComponentException("No Text component found in children.");
		}		

	}
}
