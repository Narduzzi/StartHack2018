using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TeamAVA.VolvoS.Gamification.Business;

namespace TeamAVA.VolvoS.Gamification.View {


	public class RewardButton : MonoBehaviour {

		private Button m_Button;
		private Text m_Text;
		[SerializeField] private Image m_Icon;
		[SerializeField] private Button.ButtonClickedEvent m_Action;
		[SerializeField] private Reward m_Reward;

		// Use this for initialization
		public void Initialize (Reward reward) {
			CheckComponents ();
			m_Reward = reward;
			gameObject.name = "RewardButton_" + reward.Name;
			m_Text.text = reward.Name;
			// AffectImage ();

			// Button action on click
			// gameObject.GetComponent<Button>().onClick = m_Action;
		}

		private void CheckComponents(){
			m_Button = this.gameObject.GetComponent<Button>();
			if(m_Button == null) throw new MissingComponentException("No Button component found.");

			m_Text = this.gameObject.GetComponentInChildren<Text>();
			if(m_Text == null) throw new MissingComponentException("No Text component found in children.");

			m_Icon = this.transform.GetChild(1).GetComponent<Image>();
			if(m_Icon == null) throw new MissingComponentException("No Image component found.");
		}

		public Reward Reward {
			get {
				return this.m_Reward;
			}
			set {
				m_Reward = value;
			}
		}
		

	}
}
