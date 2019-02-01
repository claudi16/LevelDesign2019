using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Adding IFPSInteract after MonoBehaviour makes this script use the IFPSInteract interface
public class MoveOnInteract : MonoBehaviour, IFPSInteract
{
	//Required method because of the IFPSInteract interface
	//This gets called when called on by another script
	//In this case the FPSInteract script
	public void OnInteract()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
		}
	}

}
