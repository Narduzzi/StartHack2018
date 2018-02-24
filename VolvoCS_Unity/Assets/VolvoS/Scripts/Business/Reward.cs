using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TeamAVA.VolvoS.Gamification.Business {

	[System.Serializable]
	public class Reward {

		[SerializeField] private string m_Name;         		
		[SerializeField] private string m_Description;
		[SerializeField] private int m_Points;
		[SerializeField] private List<Rewardable> m_Rewardable;

		public Reward ()
		{
			m_Rewardable = new List<Rewardable> ();
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

		public int Points {
			get {
				return this.m_Points;
			}
			set {
				m_Points = value;
			}
		}

		public List<Rewardable> Rewardable {
			get {
				return this.m_Rewardable;
			}
			set {
				m_Rewardable = value;
			}
		}

	}
}
