using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class GameController : MonoBehaviour {

	public GameObject inventory,player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.I)) {
			ToggleInventory ();
		}
	}

	void ToggleInventory(){
		inventory.SetActive (!inventory.activeInHierarchy);
		inventory.GetComponent<InventoryController> ().CreateInventory ();
		Cursor.visible = inventory.activeInHierarchy;  
		DisablePlayer (!inventory.activeInHierarchy);
	}

	void DisablePlayer(bool flag){
		player.GetComponent<CharacterController> ().enabled = flag;
		player.GetComponent<FirstPersonController> ().enabled = flag;
	}
}
