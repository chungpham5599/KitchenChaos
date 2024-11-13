using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainterCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    public event EventHandler OnKitchenObjectGrabbed;
    public override void Interact(Player player) 
    {
        if (!player.HasKitchenObject())
        {
            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.GetPrefab());
            kitchenObjectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(player);
            
            OnKitchenObjectGrabbed?.Invoke(this, EventArgs.Empty);
        }
    }
}
