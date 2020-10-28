using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMove : MonoBehaviour
{
    
    private float roomXValue;
    [SerializeField]
    private float roomSpeed;
    // Start is called before the first frame update
    void Start()
    {
        roomXValue = gameObject.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        roomXValue -= roomSpeed * Time.deltaTime;
        gameObject.transform.position = new Vector3(roomXValue, gameObject.transform.position.y, gameObject.transform.position.z);
    }
}
