using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

	public Transform spawnPos;
	public GameObject spawnee;

	// Update is called once per frame
	void Update()
	{
		Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
		
	}
}