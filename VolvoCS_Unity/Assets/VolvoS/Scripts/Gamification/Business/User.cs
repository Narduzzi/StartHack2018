using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TeamAVA.VolvoS.Reservation.Business;

namespace TeamAVA.VolvoS.Gamification.Business {

	[System.Serializable]
	public class User {

		[SerializeField] private string m_Username;     
		[SerializeField] private string m_Email;
		[SerializeField] private string m_Password; 
		[SerializeField] private List<Reward> m_Rewards;
		[SerializeField] private int m_Points;
		[SerializeField] private List<CarReservation> m_Reservations;

		public User ()
		{
			m_Rewards = new List<Reward> ();
			m_Reservations = new List<CarReservation> ();
		}

		public User (string username) : this ()
		{
			this.m_Username = username;
		}

		public void AddReservation(CarReservation reservation){
			m_Reservations.Add (reservation);
		}

		public void AddReward(Reward reward){
			m_Rewards.Add (reward);
			m_Points += reward.Points;
		}

		public string Username {
			get {
				return this.m_Username;
			}
			set {
				m_Username = value;
			}
		}

		public string Email {
			get {
				return this.m_Email;
			}
			set {
				m_Email = value;
			}
		}

		public string Password {
			get {
				return this.m_Password;
			}
			set {
				m_Password = value;
			}
		}

		public int Points {
			get {
				return this.m_Points;
			}
			set {
				m_Points = value;
			}
		}

		public List<Reward> Rewards {
			get {
				return this.m_Rewards;
			}
		}

	}
}
