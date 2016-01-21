using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Item : MonoBehaviour {

	public string name;
	public enum Type {equip, consumable, misc};
	public Type type;
	public int amount = 1;

	public Sprite sprite;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseEnter(){
		if (tag != "Loot") {
			transform.parent.parent.GetComponent<InventoryController> ().selectedItem = this.transform;
		}

	}

	void OnMouseExit(){
		if (tag != "Loot") {
			if (!transform.parent.GetComponent<InventoryController> ().canDragItem)
				transform.parent.GetComponent<InventoryController> ().selectedSlot = null;
		}
	}

	public void IncreaseAmount(int a){
		amount += a;
		transform.Find ("Text").GetComponent<Text>().text  = amount.ToString();

	}
}
