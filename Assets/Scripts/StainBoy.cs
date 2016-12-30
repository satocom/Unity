using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StainBoy : Token {

	public static int Count = 0;

	// Use this for initialization
	void Start () {

		Count++;
		SetSize (SpriteWidth / 2, SpriteHeight / 2);

		// move at randome
		float dir = Random.Range (0, 359);
		float speed = 1.25f;

		SetVelocity (dir, speed);
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 min = GetWorldMin ();
		Vector2 max = GetWorldMax ();

		if (X < min.x || max.x < X) {
			VX *= -1;
			ClampScreen ();
		}

		if (Y < min.y || max.y < Y) {
			VY *= -1;
			ClampScreen ();
		}
	}

	public void OnMouseDown() {
		Count--;
		DestroyObj ();
	}
}
