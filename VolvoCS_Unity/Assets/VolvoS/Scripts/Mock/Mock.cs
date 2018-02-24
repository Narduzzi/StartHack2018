using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TeamAVA.VolvoS.Gamification.Business;

namespace TeamAVA.VolvoS.Gamification {

	public class Mock : MonoBehaviour {

		[SerializeField] private Game m_Game;   
		[SerializeField] private List<Reward> m_AvailableRewards;

		[SerializeField] private User m_User;   

		public void CreateRewards(){
			Reward CleanCarReward = new Reward ();
			CleanCarReward.Points = 25;
			Achievment CleanCarAchievment = new Achievment ();
			CleanCarAchievment.Tasks.Add (new Task ("CleanCar", "Clean the car"));
			CleanCarReward.Rewardable.Add (CleanCarAchievment);
			m_AvailableRewards.Add (CleanCarReward);
		}

		public void CreateUser(){
			User max = new User ("Max");
		}


	}
}
