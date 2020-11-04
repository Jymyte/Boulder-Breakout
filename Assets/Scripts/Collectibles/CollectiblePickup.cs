using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectiblePickup : MonoBehaviour
{
    public delegate void PickUp();
    public static event PickUp pickUp;  

    void itemPickedUp() {
        if(pickUp != null) {
            pickUp();
        }

        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider target) {
        if(target.tag == "Player") {
            itemPickedUp();
        }
    }

}

