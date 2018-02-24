using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TeamAVA.VolvoS.Gamification.Business {

	[System.Serializable]
	public class Task {

		[SerializeField] private string m_Name;         		
		[SerializeField] private string m_Description;

		public Task ()
		{
		}

		public Task (string name, string description)
		{
			this.m_Name = name;
			this.m_Description = description;
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

	}
}
