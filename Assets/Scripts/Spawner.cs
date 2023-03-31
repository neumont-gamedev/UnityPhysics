using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	[SerializeField] GameObject prefab;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.O))
		{
			Instantiate(prefab, transform.position, transform.rotation);
		}
	}
}
