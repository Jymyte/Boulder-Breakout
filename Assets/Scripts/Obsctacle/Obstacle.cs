using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private float speed = -3f;
    private Rigidbody myBody;
    // Start is called before the first frame update
    private void Awake() {
        myBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        myBody.velocity = new Vector2(speed, 0f);
    }
}
