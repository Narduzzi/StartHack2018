using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TeamAVA.VolvoS.Reservation.Business {

	[System.Serializable]
	public class Car {

		[SerializeField] private int m_Id;
		[SerializeField] private string m_Reference;
		[SerializeField] private string m_Brand;
		[SerializeField] private string m_Model;
		[SerializeField] private string m_Immatriculation;
		
		public Car ()
		{
		}

		public Car (int m_Id, string m_Reference, string m_Brand, string m_Model, string m_Immatriculation)
		{
			this.m_Id = m_Id;
			this.m_Reference = m_Reference;
			this.m_Brand = m_Brand;
			this.m_Model = m_Model;
			this.m_Immatriculation = m_Immatriculation;
		}

		public int Id {
			get {
				return this.m_Id;
			}
			set {
				m_Id = value;
			}
		}

		public string Reference {
			get {
				return this.m_Reference;
			}
			set {
				m_Reference = value;
			}
		}

		public string Brand {
			get {
				return this.m_Brand;
			}
			set {
				m_Brand = value;
			}
		}

		public string Model {
			get {
				return this.m_Model;
			}
			set {
				m_Model = value;
			}
		}

		public string Immatriculation {
			get {
				return this.m_Immatriculation;
			}
			set {
				m_Immatriculation = value;
			}
		}
		
	}
}
