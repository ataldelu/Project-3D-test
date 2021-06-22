using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCharacterController : MonoBehaviour
{
    public GameObject character;   
    Vector3 distance;

    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - character.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 2, Vector3.up) * distance;
        distance = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * 2, Vector3.left) * distance;

        transform.position = character.transform.position + distance;
        transform.LookAt(character.transform.position);        

    }
}
