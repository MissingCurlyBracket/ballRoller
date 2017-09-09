using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform sphere;
	public Text scoreText;

	// Update is called once per frame
	void Update () {

		scoreText.text = sphere.position.z.ToString("0");

	}
}
