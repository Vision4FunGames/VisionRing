using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;



public class EquipmentManager : MonoBehaviour {

	#region Singleton


	public static EquipmentManager instance {
		get {
			if (_instance == null) {
				_instance = FindObjectOfType<EquipmentManager> ();
			}
			return _instance;
		}
	}
	static EquipmentManager _instance;
	private GameObject currentWeapon,currentInventoryWeapon;
	
	public delegate void OnItemAdded();
	public OnItemAdded onItemAddedCallback;
	void Awake ()
	{
		_instance = this;
	}

	#endregion

	public List<Equipment> ItemDatabase;
	public Equipment[] defaultWear;

	public Equipment[] currentEquipment;

	private Equipment[] saveEquipment;
	SkinnedMeshRenderer[] currentMeshes;
	private SkinnedMeshRenderer[] currentInventoryMeshes;
	
	public SkinnedMeshRenderer targetMesh;
	public SkinnedMeshRenderer targetEnvanterMesh;

	public GameObject currentItemInventoryParent;
	// Callback for when an item is equipped
	public delegate void OnEquipmentChanged(Equipment newItem, Equipment oldItem);
	public event OnEquipmentChanged onEquipmentChanged;

	Inventory inventory;
	//private EquippedInventory equippedInventory;
	public GameObject rightHand;
	public GameObject inventoryHand;
	public Equipment[] upgradeEquipment;
	public InventorySlot[] upgradeSlots;
	void Start ()
	{
		ResetObjects();
		inventory = Inventory.instance;
		//equippedInventory = EquippedInventory.instance;
		int numSlots = System.Enum.GetNames (typeof(EquipmentSlot)).Length;
		currentEquipment = new Equipment[numSlots];
		currentMeshes = new SkinnedMeshRenderer[numSlots];
		currentInventoryMeshes = new SkinnedMeshRenderer[numSlots];
		saveEquipment = new Equipment[numSlots];
		saveEquipment = ES3.Load("currentItems", currentEquipment);
		inventory.items.Clear();
		inventory.items = ES3.Load("inventory", inventory.items);
		EquipAllDefault ();
		onItemAddedCallback += UpdateUpgradeSlots;
	}

	

	public void ResetObjects()
	{
		for (int i = 0; i < ItemDatabase.Count; i++)
		{
			ItemDatabase[i].showInInventory = false;
		}
	}
	
	void Update() {
		if (Input.GetKeyDown (KeyCode.U)) {
			UnequipAll ();

		}
	}


	public Equipment GetEquipment(EquipmentSlot slot) {
		
		return currentEquipment [(int)slot];
	}

	// Equip a new item
	public void Equip (Equipment newItem)
	{
		Equipment oldItem = null;

		// Find out what slot the item fits in
		// and put it there.
		int slotIndex = (int)newItem.equipSlot;

		// If there was already an item in the slot
		// make sure to put it back in the inventory
		if (currentEquipment[slotIndex] != null)
		{
			Debug.Log("Item var olan ile degisti");
			oldItem = currentEquipment [slotIndex];
			inventory.Add(oldItem);
			oldItem.showInInventory = false;
		}
		// An item has been equipped so we trigger the callback
		currentEquipment [slotIndex] = newItem;
		//equippedInventory.Add(newItem);
		if (onEquipmentChanged != null)
			onEquipmentChanged.Invoke(newItem, oldItem);
		Debug.Log(newItem.name + " equipped!");
		newItem.showInInventory = true;
		if (newItem.mesh ) {
			AttachToMesh (newItem.mesh,slotIndex);
		} 
		else if (newItem.prefab)
		{
			if (currentWeapon != null)
			{
				Destroy(currentWeapon);
				Destroy(currentInventoryWeapon);
			}
			currentWeapon = Instantiate(newItem.prefab,new Vector3(rightHand.transform.position.x, rightHand.transform.position.y, rightHand.transform.position.z),
				Quaternion.identity);
			currentWeapon.transform.parent = rightHand.transform;
			currentWeapon.transform.localPosition = new Vector3(0, 0.0028f, 0);
			currentWeapon.transform.localEulerAngles = new Vector3(-31.375f,-43.925f,-97.642f);
			currentInventoryWeapon = Instantiate(newItem.prefab,new Vector3(inventoryHand.transform.position.x, inventoryHand.transform.position.y, inventoryHand.transform.position.z),
				Quaternion.identity);
			currentInventoryWeapon.transform.parent = inventoryHand.transform;
			currentInventoryWeapon.transform.localPosition = new Vector3(0, 0.0028f, 0);
			currentInventoryWeapon.transform.localEulerAngles = new Vector3(-31.375f,-43.925f,-97.642f);
			
		}
		//equippedItems [itemIndex] = newMesh.gameObject;
		
		
	}

	public void Unequip(int slotIndex) {
		if (currentEquipment[slotIndex] != null)
		{
			Equipment oldItem = currentEquipment [slotIndex];
			inventory.Add(oldItem);
			oldItem.showInInventory = false;
			//equippedInventory.Remove(oldItem);	
			currentEquipment [slotIndex] = null;
			if (currentMeshes [slotIndex] != null) {
				Destroy (currentMeshes [slotIndex].gameObject);
				Destroy(currentInventoryMeshes[slotIndex].gameObject);
			}
			else if (slotIndex == 2 && currentWeapon != null)
			{
				Destroy(currentWeapon);
				Destroy(currentInventoryWeapon);
			}
			
			//equippedInventory.Remove(oldItem);
			InventoryUI.instance.currentItemsParent.transform.GetChild(0).transform.GetChild(slotIndex).GetComponent<InventorySlot>().ClearSlot();
			// Equipment has been removed so we trigger the callback
			if (onEquipmentChanged != null)
				onEquipmentChanged.Invoke(null, oldItem);
			if (inventory.onItemChangedCallback != null)
				inventory.onItemChangedCallback.Invoke();
		}
		ES3.Save("currentItems",currentEquipment);
		ES3.Save("inventory",inventory.items);
		Debug.Log("Saved");
	}

	#region Upgrade
	public void UpgradeEquip(Equipment newItem)
	{
		for (int i = 0; i < upgradeEquipment.Length; i++)
		{
			if (upgradeEquipment[i] == null)
			{
				upgradeEquipment[i] = newItem;
				newItem.RemoveFromInventory();
				if (onItemAddedCallback!= null)
				{
					onItemAddedCallback.Invoke();
				}
				
				return;
			}
			
		}
	}
	private void UpdateUpgradeSlots()
	{
		for (int i = 0; i < upgradeSlots.Length; i++)
		{
			if (upgradeEquipment[i]!=null)
			{
				upgradeSlots[i].AddItem(upgradeEquipment[i]);
			}
			else
			{
				upgradeSlots[i].ClearSlot();
			}
		}
	}

	public void UpgradeItem()
	{
		for (int i = 0; i < upgradeEquipment.Length; i++)
		{
			if (upgradeEquipment[i] == null)
			{
				return;
			}
		}
		if (upgradeEquipment[0].name == upgradeEquipment[1].name && upgradeEquipment[0].name == upgradeEquipment[2].name) 
		{
			if (upgradeEquipment[0].itemLevel == upgradeEquipment[1].itemLevel && upgradeEquipment[0].itemLevel == upgradeEquipment[2].itemLevel)
			{
				upgradeEquipment[0].itemLevel++;
				upgradeEquipment[0].showInInventory = true;
				inventory.Add(upgradeEquipment[0]);
				
				if (inventory.onItemChangedCallback!=null)
				{
					inventory.onItemChangedCallback.Invoke();
				}

				ClearUpgradeSlots();
			}
		}
	}

	private void ClearUpgradeSlots()
	{
		for (int i = 0; i < upgradeEquipment.Length; i++)
		{
			upgradeEquipment[i] = null;
		}
		if (onItemAddedCallback != null)
		{
			onItemAddedCallback.Invoke();
		}
		
	}

	#endregion
	
	void UnequipAll() {
		for (int i = 0; i < currentEquipment.Length; i++) {
			Unequip (i);
		}
		EquipAllDefault ();
	}

	void EquipAllDefault() {
		foreach (Equipment e in saveEquipment) {
			if (e != null)
			{
				Equip (e);
			}
			
		}
		
	}
	
	void AttachToMesh(SkinnedMeshRenderer mesh, int slotIndex) {

		if (currentMeshes [slotIndex] != null && slotIndex != 2) {
			Destroy (currentMeshes [slotIndex].gameObject);
			Destroy(currentInventoryMeshes[slotIndex].gameObject);
		}
		SkinnedMeshRenderer newMesh = Instantiate(mesh) as SkinnedMeshRenderer;
		newMesh.bones = targetMesh.bones;
		newMesh.rootBone = targetMesh.rootBone;
		currentMeshes [slotIndex] = newMesh;
		//Inventory Player
		SkinnedMeshRenderer newMesh2 = Instantiate(mesh) as SkinnedMeshRenderer;
		newMesh2.bones = targetEnvanterMesh.bones;
		newMesh2.rootBone = targetEnvanterMesh.rootBone;
		currentInventoryMeshes [slotIndex] = newMesh2;
	}
}