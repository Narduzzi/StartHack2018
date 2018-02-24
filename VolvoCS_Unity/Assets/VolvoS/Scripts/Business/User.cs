using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TeamAVA.VolvoS.Gamification.Business {

	[System.Serializable]
	public class User {

		[SerializeField] private string m_Username;     
		[SerializeField] private string m_Email;
		[SerializeField] private string m_Password; 
		[SerializeField] private List<Reward> m_Rewards;

		public User ()
		{
		}

		public User (string username)
		{
			this.m_Username = username;
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

		public List<Reward> Rewards {
			get {
				return this.m_Rewards;
			}
			set {
				m_Rewards = value;
			}
		}

	}
}
