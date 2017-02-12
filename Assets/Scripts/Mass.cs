using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mass : MonoBehaviour {
	public Text sliderValue;
	public Slider mass;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		sliderValue.text = mass.value.ToString ();
	}
}
