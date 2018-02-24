using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Map;
using Mapbox.Utils;
using Mapbox.Unity.Utilities;
using System.Web.UI;
using SimpleJSON;

public class ParkingFinder : MonoBehaviour {
	public Vector2 LatLng = new Vector2 (46.9899997f, 6.92627429f);
	public Vector2 oldLatLng = new Vector2(0.0f,0.0f);
	public GameObject Map;
	public AbstractMap _map;
	public float radius = 200;
	Dictionary<string, Vector2> parkings = new Dictionary<string, Vector2> ();

	// Use this for initialization
	void Start () {
		StartCoroutine("GetParkingSlots");
		GetCurrentLocation ();
	}
	
	// Update is called once per frame
	void Update () {
		GetCurrentLocation ();
		if(DistanceGPS(oldLatLng,LatLng)>radius){
			Debug.LogWarning ("DOWNLOAD");
			//If user moved more than 500m
			oldLatLng = LatLng;
			StartCoroutine("GetParkingSlots");
		}
		UpdateParkings ();
	}

	void GetCurrentLocation(){
		if (Map == null) {
			throw new MissingComponentException ("Map is NULL!");
		} else {
			_map = Map.GetComponent<QuadTreeBasicMap> ();
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
		//Clean
		GameObject[] gos = GameObject.FindGameObjectsWithTag ("Parking");
		DestroyListGameObjects (gos);
		parkings = new Dictionary<string, Vector2> ();

		//Request
		string url = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?location=" + LatLng.x + "," + LatLng.y + "&radius="+radius+"&types=parking&sensor=false&key=AIzaSyBqKtSql3ay7qvXSMUluVo3hSmPoLMTIBY";
		using (WWW www = new WWW(url))
		{
			yield return www;
			string text = www.text;
			JSONNode json = JSON.Parse (text);
			JSONNode results = json ["results"];
			for (int i = 0; i < results.Count; i++) {
				float lat = results [i] ["geometry"] ["location"] ["lat"];
				float lng = results [i] ["geometry"] ["location"] ["lng"];
				string name = results [i] ["name"];
				Debug.Log(name+" : "+"(" + lat + ";" + lng + ")");
				parkings.Add (name, new Vector2 (lat, lng));
			}
		}

		foreach (KeyValuePair<string, Vector2> entry in parkings) {
			AddObject (entry.Key, entry.Value.x, entry.Value.y);
		}
	}

	void DestroyListGameObjects(GameObject[] gos){
		foreach (GameObject go in gos) {
			Destroy (go);
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

	void AddObject(string name, float lat, float lng){
		_map.CenterMercator.ToString ();
		_map.WorldRelativeScale.ToString ();
		GameObject go = GameObject.CreatePrimitive (PrimitiveType.Cube);
		go.tag = "Parking";
		go.transform.localPosition = Conversions.GeoToWorldPosition (new Vector2d (lat, lng), _map.CenterMercator, _map.WorldRelativeScale).ToVector3xz ();
	}

	void UpdateParkings(){
		GameObject[] gos = GameObject.FindGameObjectsWithTag ("Parking");
		int i = 0;
		foreach (KeyValuePair<string, Vector2> entry in parkings) {
			Vector2 parking_pos = entry.Value;
			float lat = parking_pos.x;
			float lng = parking_pos.y;
			GameObject go = gos [i];
			go.tag = "Parking";
			go.transform.localPosition = Conversions.GeoToWorldPosition (new Vector2d (lat, lng), _map.CenterMercator, _map.WorldRelativeScale).ToVector3xz ();
			i++;
		}
	}
}