using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Map;
using Mapbox.Utils;
using System.Web.UI;

public class ParkingFinder : MonoBehaviour {
	public Vector2 LatLng = new Vector2 (46.9899997f, 6.92627429f);
	public Vector2 oldLatLng = new Vector2(0.0f,0.0f);
	public GameObject Map;
	// Use this for initialization
	void Start () {
		StartCoroutine("GetParkingSlots");
		GetCurrentLocation ();
	}
	
	// Update is called once per frame
	void Update () {
		GetCurrentLocation ();
		if(DistanceGPS(oldLatLng,LatLng)>500){
			Debug.LogWarning ("DOWNLOAD");
			//If user moved more than 500m
			oldLatLng = LatLng;
			StartCoroutine("GetParkingSlots");
		}
	}

	void GetCurrentLocation(){
		if (Map == null) {
			throw new MissingComponentException ("Map is NULL!");
		} else {
			QuadTreeBasicMap quadTreeMap = Map.GetComponent<QuadTreeBasicMap> ();
			Vector2d quadCenter = quadTreeMap.CenterLatitudeLongitude;
			float vx = (float)quadCenter.x;
			float vy = (float)quadCenter.y;
			Debug.Log ("(" + vx + ";" + vy + ")");
			LatLng = new Vector2 (vx, vy);
		}
	}

	IEnumerator GetParkingSlots()
	{	
		string url = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=" + LatLng.x + "," + LatLng.y + "&radius=500&types=parking&sensor=false&key=AIzaSyBqKtSql3ay7qvXSMUluVo3hSmPoLMTIBY";
		using (WWW www = new WWW(url))
		{
			yield return www;
			string text = www.text;
		}
	}

	float degreesToRadians(float degrees) {
		return degrees * Mathf.PI / 180.0f;
	}

	float DistanceGPS (Vector2 a, Vector2 b){
		//Returns distance in meter between two gps points
	
		float lat1 = a.x;
		float lon1 = a.y;
		float lat2 = b.x;
		float lon2 = b.y;

		int earthRadiusKm = 6371;

		float dLat = degreesToRadians(lat2-lat1);
		float dLon = degreesToRadians(lon2-lon1);

		lat1 = degreesToRadians(lat1);
		lat2 = degreesToRadians(lat2);

		float value = Mathf.Sin(dLat/2.0f) * Mathf.Sin(dLat/2.0f) +
		Mathf.Sin(dLon/2.0f) * Mathf.Sin(dLon/2.0f) * Mathf.Cos(lat1) * Mathf.Cos(lat2); 
		float c_value = 2 * Mathf.Atan2(Mathf.Sqrt(value), Mathf.Sqrt(1.0f-value)); 
		return earthRadiusKm * c_value * 1000;
	}
}