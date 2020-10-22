using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Rooms;
    private List<GameObject> roomsToSpawn = new List<GameObject>();

    void Awake()
    {
        initializeRooms();
    }
    void initializeRooms() {

    }

    void Update()
    {
        
    }
}
