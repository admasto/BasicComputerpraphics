﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraViewController : MonoBehaviour {

	public GreyValueCam greyValues = gameObject.GetComponent<GreyValueCam>();
	public HeatmapCam heatmap = gameObject.GetComponent<HeatMapCam>();
	public TemperaturemapCam temperaturemap = gameObject.GetComponent<TemperaturemapCam>();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp("0")){

		} 
		if (Input.GetKeyUp("1")){
			greyValues.OnRenderImage ();
		} 
		if (Input.GetKeyUp("2")) {
			heatmap.OnRenderImage ();
		}
		if (Input.GetKeyUp ("3")) {
			temperaturemap.OnRenderImage ();
		}
}
