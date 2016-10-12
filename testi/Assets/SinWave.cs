using UnityEngine;
using System.Collections;

public class SinWave : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.localEulerAngles = new Vector3 (
			90f,
			10f * Mathf.Sin (Time.time),
			2f * Mathf.Sin (Time.time * 3)
		);
	}
}
