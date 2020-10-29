using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] rooms;
    private List<GameObject> roomsToSpawn = new List<GameObject>();

    private int roomNumber = 0;

    [SerializeField]
    private GameObject RoomCollector;

    /* [SerializeField]
    private GameObject TestRoom; */

    void Awake()
    {
        initializeRooms();
    }
    void initializeRooms() {
        int index = 0;
		for(int i = 0; i < rooms.Length * 3; i++) {
			GameObject obj = Instantiate(rooms[index], new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0),
                                                                new Quaternion(0,0,0,0)) as GameObject;
			roomsToSpawn.Add(obj);
			roomsToSpawn[i].SetActive(false);
			index++;
			if(index == rooms.Length) 
				index = 0;
		}
    }

    private void Start() {
        roomsToSpawn[0].SetActive(true);
    }

    void OnTriggerExit(Collider target) {
        if (target.tag == "Room End") {
            roomNumber++;
            roomsToSpawn[roomNumber].SetActive(true);
        }
    }
}
