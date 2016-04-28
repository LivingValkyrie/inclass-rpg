using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.net
/// 
/// Description: NavPrompt 
/// </summary>
public class NavPrompt : MonoBehaviour {
	#region Fields

	public GameObject prompt;

	#endregion

	void Start() {
		prompt.SetActive(false);
	}

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.CompareTag("Player")) {
			if (NavigationManager.CanNavigate(tag)) {
				prompt.SetActive(true);
				prompt.GetComponentInChildren<Text>().text = "do you want to travel to " + NavigationManager.GetRouteInformation(tag) + "?";
				Destination.Instance.loadDestination = gameObject.tag;
			}
		}
	}

	void OnCollisionExit2D( Collision2D other ) {
		if ( other.gameObject.CompareTag( "Player" ) ) {
			prompt.SetActive( false );
		}
	}
}