using UnityEngine;
using System.Collections;

[AddComponentMenu("MyScripts/Pickup")]
public class Pickup : MonoBehaviour
{
	public int points = 25;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}
	void OnTriggerEnter(Collider col)
	{
		PlayerStatus playerStatus = col.GetComponent<PlayerStatus>();
		if (playerStatus)
			playerStatus.AddPoints(points);
		Destroy(gameObject);
	}
}
