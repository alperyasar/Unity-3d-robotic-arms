using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{

	public float lifeTime = 1f;

	// Update is called once per frame
	void Update()
	{
		if (lifeTime > 0)
		{
			lifeTime -= Time.deltaTime;
			if (lifeTime <= 0)
			{
				Destruction();
			}
		}	
	}

	void Destruction()
	{
		Destroy(this.gameObject);
	}
}