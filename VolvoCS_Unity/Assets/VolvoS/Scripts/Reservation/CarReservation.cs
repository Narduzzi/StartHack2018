using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TeamAVA.VolvoS.Gamification.Business;

namespace TeamAVA.VolvoS.Reservation.Business {

	[System.Serializable]
	public class CarReservation {

		[SerializeField] private DateTime m_BeginDateTime;
		[SerializeField] private DateTime m_EndDateTime;
		[SerializeField] private Car m_Car;
		[SerializeField] private User m_User;
		[SerializeField] private Address m_Address;
		
		public CarReservation ()
		{
		}

		public CarReservation (DateTime m_BeginDateTime, DateTime m_EndDateTime, Car m_Car, User m_User, Address m_Address)
		{
			this.m_BeginDateTime = m_BeginDateTime;
			this.m_EndDateTime = m_EndDateTime;
			this.m_Car = m_Car;
			this.m_User = m_User;
			this.m_Address = m_Address;
		}		

		public DateTime BeginDateTime {
			get {
				return this.m_BeginDateTime;
			}
			set {
				m_BeginDateTime = value;
			}
		}

		public DateTime EndDateTime {
			get {
				return this.m_EndDateTime;
			}
			set {
				m_EndDateTime = value;
			}
		}

		public Car Car {
			get {
				return this.m_Car;
			}
			set {
				m_Car = value;
			}
		}

		public Address Address {
			get {
				return this.m_Address;
			}
			set {
				m_Address = value;
			}
		}

		public User User {
			get {
				return this.m_User;
			}
			set {
				m_User = value;
			}
		}
		
	}
}
