using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class CaseCell : MonoBehaviour
{
  public Equipment _Equipment;
  [System.Serializable]
  private class  ListOfSprites
  {
    public List<Equipment> _EquipmentItems;
  }

  [FormerlySerializedAs("_draggables")] [SerializeField] private List<ListOfSprites> _equipments;
  [SerializeField] private int[] _chances;


  public void Setup()
  {
    var index = Randomize();
    int rnd = Random.Range(0, _equipments[index]._EquipmentItems.Count);
    _Equipment = _equipments[index]._EquipmentItems[rnd];
   transform.parent.GetComponent<Image>().sprite = _equipments[index]._EquipmentItems[rnd].icon;
    GetComponent<Image>().sprite = _equipments[index]._EquipmentItems[rnd].icon;

  }

  private int Randomize()
  {
    int ind = 0;
    for (int i = 0; i < _chances.Length; i++)
    {
      int rand = Random.Range(0, 100);
      if (rand > _chances[i])
      {
        return i;
        
      } 
    }

    return ind;
  }
}
