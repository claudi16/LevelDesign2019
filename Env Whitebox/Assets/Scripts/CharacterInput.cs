using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class CharacterInput : MonoBehaviour {
	public float speed = 30;
	public bool PlayerInput = true;
	void Start () {
		StartCoroutine(CharInput());
	}

	IEnumerator CharInput(){
		while(PlayerInput){
			if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(Vector3.right * Time.deltaTime * speed);
			}
			if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(Vector3.left * Time.deltaTime * speed);
			}
			if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(Vector3.forward * Time.deltaTime * speed);
			}
			if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(Vector3.back * Time.deltaTime * speed);
			}
		yield return new WaitForSeconds(0.01f);

		}
	}
}

