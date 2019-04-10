using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Map;
using Mapbox.Utils;
using UnityEngine.UI;

public class GPSController : MonoBehaviour {


	public AbstractMap Prefabs;
	private AbstractMap mapInstance;
	public Location location;
	public GameObject InputCanvas;


	// Use this for initialization
    /// <summary>
    /// sadhjkjsadksadhjadgsf
    /// </summary>
	void Start () {

        //Create a map and set GPS
		CreateMap ();
		SetGPS ();

	}

	private void SetGPS()
	{
        location = new Location();

        //returned a vector2d as location which is set to UHCL coordinates
		location.locationGPS = new Vector2d (29.5779, -95.1040);
        //populate location on the map
		mapInstance.SetCenterLatitudeLongitude (location.locationGPS);
	}

	public void CreateMap()
	{
		mapInstance = Instantiate (Prefabs) as AbstractMap;
	}


    //Turn on elvation on map
	private void SetElevation()
	{
		//mapInstance.Terrai
	}

    /// <summary>
    /// Selects the location button.
    /// </summary>
    /// <param name="buttonNo">Button no.</param>
	public void SelectLocationButton(int buttonNo)
	{
        //Hide the front UI
        Debug.Log("I'm Working");
		InputCanvas.SetActive (false);
	}
	





	// Update is called once per frame
	void Update () {
		
	}
}
