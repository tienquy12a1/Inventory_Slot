using UnityEngine;
using System.Collections;

public class MyCharacterController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


	void OnTriggerEnter(Collider other){
		if (other.tag == "Loot") {
			print ("We picked " + other.name);
			GameDB._instance.AddItem (other.GetComponent<Item> ());
			GameObject.Destroy (other.gameObject, 0.1f);
		}
	}
}
