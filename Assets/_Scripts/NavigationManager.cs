using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.net
/// 
/// Description: NavigationManager 
/// </summary>
public class NavigationManager : MonoBehaviour {
	#region Fields

	public static Dictionary<string, string> RouteInformation = new Dictionary<string, string>() {
		{"World", "The big bad world"},
		{"Cave", "The deep dark cave"}
	};

	#endregion

	/// <summary>
	/// 
	/// </summary>
	/// <param name="destination"></param>
	/// <returns></returns>
	public static string GetRouteInformation(string destination) {
		
		return RouteInformation.ContainsKey(destination) ? RouteInformation[destination] : null;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="destination"></param>
	/// <returns></returns>
	public static bool CanNavigate(string destination) {
		return true;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="destination"></param>
	public static void NavigateTo(string destination) {
		SceneManager.LoadScene(Destination.Instance.loadDestination);
	}

}