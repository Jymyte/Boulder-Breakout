using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Rooms;
    private List<GameObject> roomsToSpawn = new List<GameObject>();

    [SerializeField]
    private GameObject RoomCollector;

    [SerializeField]
    private GameObject TestRoom;

/*     void Awake()
    {
        initializeRooms();
    }
    void initializeRooms() {

    } */

    private void Start() {
        Instantiate(TestRoom, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0),
        new Quaternion(0,0,0,0));
    }

    void Update()
    {
        
    }
}
