using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace TeamAVA.VolvoS.Reservation.Business {

	[System.Serializable]
	public class Address {

		[SerializeField] private string m_Address;
		[SerializeField] private string m_City;
		[SerializeField] private string m_Npa;
		[SerializeField] private Vector2 m_GeoPos;
		
		public Address ()
		{
			
		}

		public Address (string m_Address, string m_City, string m_Npa)
		{
			this.m_Address = m_Address;
			this.m_City = m_City;
			this.m_Npa = m_Npa;
		}

		public string AddressName {
			get {
				return this.m_Address;
			}
			set {
				m_Address = value;
			}
		}

		public string City {
			get {
				return this.m_City;
			}
			set {
				m_City = value;
			}
		}

		public string Npa {
			get {
				return this.m_Npa;
			}
			set {
				m_Npa = value;
			}
		}

		public Vector2 GeoPos {
			get {
				return this.m_GeoPos;
			}
			set {
				m_GeoPos = value;
			}
		}

		
	}
}
