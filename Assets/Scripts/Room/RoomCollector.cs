using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCollector : MonoBehaviour
{
    void OnTriggerEnter(Collider target) {
        if (target.tag == "Room End") {
            target.transform.parent.gameObject.SetActive(false);
        }
    }
}
