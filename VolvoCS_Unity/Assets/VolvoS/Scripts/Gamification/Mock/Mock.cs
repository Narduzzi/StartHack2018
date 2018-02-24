using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TeamAVA.VolvoS.Gamification.Business;
using TeamAVA.VolvoS.Reservation.Business;

namespace TeamAVA.VolvoS.Gamification {

	public class Mock {

		public Mock(){
		}

		public List<Car> CreateCars(){
			List<Car> m_Cars = new List<Car> ();
			m_Cars.Add(new Car (1, "1", "Volvo", "Modele 1", "VD1000"));
			m_Cars.Add(new Car (2, "2", "Volvo", "Modele 2", "VD2000"));
			m_Cars.Add(new Car (3, "3", "Volvo", "Modele 3", "VD3000"));
			m_Cars.Add(new Car (4, "4", "Volvo", "Modele 4", "VD4000"));
			m_Cars.Add(new Car (5, "5", "Volvo", "Modele 5", "VD5000"));	

			return m_Cars;
		}

		public List<User> CreateUsers(){
			List<User> m_Users = new List<User>();
			m_Users.Add (new User ("Max"));
			m_Users.Add (new User ("Simon"));
			return m_Users;
		}

		public Dictionary<string, Reward> CreateRewards(){
			Dictionary<string, Reward> m_AvailableRewards = new Dictionary<string, Reward> ();

			Reward DoReservation = new Reward ();
			DoReservation.Name = "DoReservation";
			DoReservation.Points = 5;
			Achievment DoReservationAchievement = new Achievment ();
			DoReservationAchievement.Tasks.Add (new Task ("DoReservation", "Do a reservation"));
			DoReservation.Rewardable.Add (DoReservationAchievement);
			m_AvailableRewards.Add (DoReservation.Name, DoReservation);

			Reward CleanCarReward = new Reward ();
			CleanCarReward.Name = "CleanCarReward";
			CleanCarReward.Points = 25;
			Achievment CleanCarAchievment = new Achievment ();
			CleanCarAchievment.Tasks.Add (new Task ("CleanCar", "Clean the car"));
			CleanCarReward.Rewardable.Add (CleanCarAchievment);
			m_AvailableRewards.Add(CleanCarReward.Name, CleanCarReward);

			Reward TakePersonReward = new Reward ();
			TakePersonReward.Name = "TakePersonReward";
			TakePersonReward.Points = 15;
			Achievment TakePersonAchievment = new Achievment ();
			TakePersonAchievment.Tasks.Add (new Task ("TakePerson", "Take a person"));
			TakePersonReward.Rewardable.Add (TakePersonAchievment);
			m_AvailableRewards.Add (TakePersonReward.Name, TakePersonReward);

			return m_AvailableRewards;
		}

	}
}
