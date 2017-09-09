using UnityEngine;

public class FollowSphere : MonoBehaviour {

	public Transform sphere;
	public Vector3 offset;

	// Update is called once per frame
	void Update () {

		transform.position = sphere.position + offset;
	}
}
