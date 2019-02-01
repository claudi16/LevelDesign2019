using UnityEngine;

//This script goes on the player
public class FPSInteract : MonoBehaviour {
	
	[Tooltip("How far the ray shoots out/how far you haveto be to interact with something")]
	public float interactDistance = 1;
	
	[Tooltip("Where the ray gets shot out from.\nUsually the camera for FPS")]
	public Transform raycastPoint;
	
	//Add a new layer to the player and check all but the player so the raycast doesn't hit the player
	[Tooltip("Determines which layers the raycast hits")]
	public LayerMask layerMask;
	
	private IFPSInteract[] interacts;

	void Update () {
		
		//Raycast stuff
		RaycastHit hit;
		Ray ray = new Ray(raycastPoint.position, raycastPoint.forward);
		//Debug.DrawRay(raycastPoint.position, raycastPoint.forward * interactDistance, Color.red);
		
		if(Physics.Raycast(ray, out hit, interactDistance, layerMask))
		{
			//Get all interfaces on object that is being hit by the ray
			interacts = hit.collider.gameObject.GetComponents<IFPSInteract>();
			
			//run all the interfaces from the object
			foreach (var interact in interacts)
			{
				if (interact != null)
				{
					interact.OnInteract();
				}
			}
		}
	}
}