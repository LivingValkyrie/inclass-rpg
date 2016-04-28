using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.net
/// 
/// Description: Destination 
/// </summary>
public class Destination : MonoBehaviour {

	#region Fields

	public static Destination Instance;
	public string loadDestination;

	#endregion
	
	void Start () {
		Instance = this;
	}
	
	void Update () {
	
	}
}
