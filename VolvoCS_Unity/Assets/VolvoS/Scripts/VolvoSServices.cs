using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TeamAVA.VolvoS.Gamification.Business;
using TeamAVA.VolvoS.Reservation.Business;
using System;
using TeamAVA.VolvoS.Gamification;

public class VolvoSServices {

	private Game m_Game;
	private Mock m_Mock;

	[SerializeField] private List<User> m_Users;  
	[SerializeField] private List<Car> m_Cars; 
	[SerializeField] private Dictionary<string, Reward> m_AvailableRewards;

	public VolvoSServices(){
		Debug.Log ("Initialise Services");
		m_Game = new Game ();
		m_Mock = new Mock ();

		m_Cars = m_Mock.CreateCars ();
		m_Users = m_Mock.CreateUsers ();
		m_AvailableRewards = m_Mock.CreateRewards ();

		CreateCarReservation(m_Users[0], m_Cars[0], new Address("Chemin des puits 7", "Neuchâtel", "2037"), 
			DateTime.Now, 
			DateTime.Now);
	}

	public void CreateCarReservation(User user, Car car, Address address, DateTime BeginDate, DateTime EndDate){
		CarReservation reservation = new CarReservation (BeginDate, EndDate, car, user, address);
		// reservation.User = user;
		// Create the reward
		Debug.Log(m_AvailableRewards["DoReservation"].Name);
		user.AddReward(m_AvailableRewards["DoReservation"]);
		m_Game.GetCurrentLevel (user.Points);
	}



	public List<Reward> AvailableRewards{
		get {
			return new List<Reward> (this.m_AvailableRewards.Values);
		}
	}

	/*public Dictionary<string, Reward> AvailableRewards {
		get {
			return this.m_AvailableRewards;
		}
	}*/
}
