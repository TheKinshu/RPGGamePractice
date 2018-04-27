using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equpment", menuName = "Inventory/Equipment")]
public class Equipment : Item {

    public EquipmentSlot equipmentSlot;
    public SkinnedMeshRenderer mesh;
    public EquipmentMeshRegion[] coveredMeshRegion;
    public int armorModifier;
    public int damageModifier;

    public override void Use()
    {
        base.Use();
        //Equip the item
        EquipmentManager.instace.Equip(this);
        //Remove Equip
        RemoveFromInventory();
    }

}

public enum EquipmentSlot { Head, Chest, Legs, Weapon, Shield, Feet};
public enum EquipmentMeshRegion {  Legs, Arms, Torso }; //corresponds to body blendshapes