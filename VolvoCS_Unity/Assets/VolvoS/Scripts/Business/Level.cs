using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TeamAVA.VolvoS.Gamification.Business {

	public class Level : Rewardable {

		[SerializeField] private int m_Order;         		
		[SerializeField] private int m_MinPoint;
		[SerializeField] private int m_MaxPoint;
		[SerializeField] private List<Group> m_Groups;

		public Level ()
		{
			m_Groups = new List<Group> ();
		}

		public int Order {
			get {
				return this.m_Order;
			}
			set {
				m_Order = value;
			}
		}

		public int MinPoint {
			get {
				return this.m_MinPoint;
			}
			set {
				m_MinPoint = value;
			}
		}

		public int MaxPoint {
			get {
				return this.m_MaxPoint;
			}
			set {
				m_MaxPoint = value;
			}
		}		

		public List<Group> Groups {
			get {
				return this.m_Groups;
			}
		}

		public override string ToString ()
		{
			return string.Format ("[Level: m_Order={0}, m_MinPoint={1}, m_MaxPoint={2}]", m_Order, m_MinPoint, m_MaxPoint);
		}

	}
}
