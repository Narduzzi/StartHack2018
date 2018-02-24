using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TeamAVA.VolvoS.Gamification.Business {

	[System.Serializable]
	public class Rewardable {

		[SerializeField] private string m_Name;   
		[SerializeField] private string m_Description;
		[SerializeField] private bool m_Completed;

		public Rewardable ()
		{
		}

		public string Name {
			get {
				return this.m_Name;
			}
			set {
				m_Name = value;
			}
		}

		public string Description {
			get {
				return this.m_Description;
			}
			set {
				m_Description = value;
			}
		}

		public bool Completed {
			get {
				return this.m_Completed;
			}
			set {
				m_Completed = value;
			}
		}
		

	}
}
