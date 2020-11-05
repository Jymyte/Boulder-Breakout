using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectiblePickup : MonoBehaviour
{
    [SerializeField]
    private GameObject effect;
    public delegate void PickUp();
    public static event PickUp pickUp;  

    void itemPickedUp() {
        if(pickUp != null) {
            pickUp();
        }

        GameObject obj = Instantiate(effect, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0),
                                                                new Quaternion(0,0,0,0)) as GameObject;
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider target) {
        if(target.tag == "Player") {
            itemPickedUp();
        }
    }

}

