using UnityEngine;

public class SphereCollision : MonoBehaviour {

	public SphereMovement movement;

	void OnCollisionEnter (Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Obstacle") 
		{
			movement.enabled = false;	
			FindObjectOfType<GameManager>().EndGame();
		}
	}

}