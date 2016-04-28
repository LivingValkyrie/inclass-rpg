using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.net
/// 
/// Description: Buttons 
/// </summary>
public class Buttons : MonoBehaviour {

	#region Fields

	#endregion

	public void LoadScene(string sceneName) {
		SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
	}

	public void LoadStoredScene() {
		//SceneManager.LoadScene(Destination.Instance.loadDestination);
		NavigationManager.NavigateTo(Destination.Instance.loadDestination);
	}
}
