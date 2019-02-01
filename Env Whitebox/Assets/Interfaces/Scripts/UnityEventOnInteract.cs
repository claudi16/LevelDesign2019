using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventOnInteract : MonoBehaviour, IFPSInteract {

	public UnityEvent Event;

	public void OnInteract()
	{
		Event.Invoke();
	}

}
