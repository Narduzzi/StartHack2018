using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TeamAVA.VolvoS.Gamification.Business {

	[System.Serializable]
	public class Game {

		[SerializeField] private string m_GameName;         		
		[SerializeField] private Level[] m_Levels;
		private const int MAX_LEVEL = 10;

		public Game ()
		{
			CreateLevels ();
		}	

		private void CreateLevels(){
			m_Levels = new Level[MAX_LEVEL];
			string levelName = "Level";
			int minPoint = 0;
			int maxPoint = 50;

			for (int i = 1; i < MAX_LEVEL + 1; i++) {
				Level level = new Level ();
				level.Name = levelName + i.ToString ();
				level.MinPoint = minPoint;
				level.MaxPoint = maxPoint;

				minPoint = maxPoint + 1;
				maxPoint = 2 * maxPoint;
				m_Levels [i - 1] = level;
				// Debug.Log(level.ToString());
			}

			// Debug.Log ("Levels : " + m_Levels.Length);
		}
	}
}
