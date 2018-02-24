using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TeamAVA.VolvoS.Gamification.Business {

	public class Achievment : Rewardable {

		/// <summary> All tasks need to be completed to complete achievment</summary>
		[SerializeField] private bool m_Completed;
		[SerializeField] private List<Task> m_Tasks;

		public Achievment (){
			m_Tasks = new List<Task> ();
		}

		public List<Task> Tasks {
			get {
				return this.m_Tasks;
			}
		}

	}
}
