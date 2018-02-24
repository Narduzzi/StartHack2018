using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TeamAVA.VolvoS.Gamification.Business {

	public class Game {

		[SerializeField] private string m_GameName;         		
		[SerializeField] private List<Level> m_Levels;
		private const int MAX_LEVEL = 10;

		public Game ()
		{
			CreateLevels ();
		}	

		private void CreateLevels(){
			m_Levels = new List<Level>();
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
				m_Levels.Add(level);
				// Debug.Log(level.ToString());
			}

			Debug.Log ("Levels : " + m_Levels.Count);
		}

		public Level GetCurrentLevel(int points){
			foreach (Level level in m_Levels){
				if (points >= level.MinPoint && points < level.MaxPoint) {
					return level;
				}
			}

			return null;
		}
	}
}
