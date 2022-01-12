using UnityEngine;
using System.Collections;

[AddComponentMenu("MyScripts/Damage")]
public class Damage : MonoBehaviour
{
	public int damage = 25;

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
			playerStatus.ApplyDamage(damage);
	}
}
