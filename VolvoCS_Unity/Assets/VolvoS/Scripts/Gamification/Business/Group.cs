using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TeamAVA.VolvoS.Gamification.Business {

	public class Group : Rewardable {

		[SerializeField] private List<Achievment> m_Achievments;

		public Group (){
			m_Achievments = new List<Achievment> ();
		}

		public List<Achievment> Achievments {
			get {
				return this.m_Achievments;
			}
		}

	}
}
