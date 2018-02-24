using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TeamAVA.VolvoS.Gamification.Business;

namespace TeamAVA.VolvoS.Gamification.View {


	public class RewardsPanel : MonoBehaviour {

		[SerializeField] private RewardButton m_Button; 
		[SerializeField] private Transform m_Parent; 

		// Use this for initialization
		void Start () {
			
		}

		public void CreateRewardsButton(List<Reward> rewards){
			foreach (Reward reward in rewards) {
				GameObject button = InstantiateButton (m_Button.gameObject, m_Parent); 
				button.GetComponent<RewardButton> ().Initialize (reward);
			}
		}

		public GameObject InstantiateButton(GameObject reference, Transform parent){
			// Instantiation d'un GameObject
			GameObject newButton = GameObject.Instantiate (reference) as GameObject;
			newButton.SetActive (true);
			// Ajouter comme fils du parent
			newButton.transform.SetParent(parent);
			// La taille est a 1
			newButton.transform.localScale = new Vector3 (1f, 1f, 1f);
			newButton.transform.localRotation = Quaternion.Euler (Vector3.zero);
			newButton.transform.localPosition = Vector3.zero;
			return newButton;
		}		

	}
}
