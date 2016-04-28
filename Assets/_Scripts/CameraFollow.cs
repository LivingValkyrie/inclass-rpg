using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.net
/// 
/// Description: CameraFollow 
/// </summary>
public class CameraFollow : MonoBehaviour {
	#region Fields

	public float xMargin = 1.5f;
	public float yMargin = 1.5f;
	public float xSmooth = 1.5f;
	public float ySmooth = 1.5f;
	public Vector2 maxXandY, minXandY;
	public Transform player;

	#endregion

	void Awake() {
		player = GameObject.FindWithTag("Player").transform;

		if (player == null) {
			Debug.LogError("player is missing in dis bitch!");
		}

		var backgroundBounds = GameObject.Find("Background").GetComponent<SpriteRenderer>().bounds;

		var cameraTopLeft = Camera.main.ViewportToWorldPoint(Vector3.zero);
		var cameraBottomRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));

		minXandY.x = backgroundBounds.min.x - cameraTopLeft.x;
		maxXandY.x = backgroundBounds.max.x - cameraBottomRight.x;
	}

	void LateUpdate() {
		float targetX = transform.position.x;
		float targetY = transform.position.y;

		if (CheckXMargin()) {
			//print("wef");
			targetX = Mathf.Lerp(transform.position.x, player.position.x, xSmooth * Time.deltaTime);
		}

		if (CheckYMargin()) {
			targetY = Mathf.Lerp(transform.position.y, player.position.y, ySmooth * Time.deltaTime);
		}

		//print(targetX + " " + targetY + " before clamp");

		targetX = Mathf.Clamp(targetX, minXandY.x, maxXandY.x);
		targetY = Mathf.Clamp(targetY, minXandY.y, maxXandY.y);

		//print(targetX + " " + targetY + " after clamp");

		transform.position = new Vector3(targetX, targetY, transform.position.z);
	}

	bool CheckXMargin() {
		return Mathf.Abs(transform.position.x - player.position.x) > xMargin;
	}

	bool CheckYMargin() {
		return Mathf.Abs(transform.position.y - player.position.y) > yMargin;
	}
}