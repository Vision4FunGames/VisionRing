using UnityEngine;

public class IapSuccessList : MonoBehaviour
{
    public testiap Testiap;
   public void BuyGold(int amount)
   {
     
       Debug.Log("Buy "+amount+" gold");
       Testiap.Debbbb(amount);
   }
   
   
   public void BuyGem(int amount)
   {

       Debug.Log("Buy "+amount+" gem");
       Testiap.Debbbb(amount);
   }
   
}
