using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField]
    float _sensX = 100f;

    [SerializeField]
    float _sensY = 100f;

    public Transform playerBody;

    // [SerializeField]
    // GameObject _canvas;

    float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * _sensX;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * _sensY;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f,0f);
        playerBody.Rotate(Vector3.up * mouseX);

        // if(Input.GetKeyDown(KeyCode.Z)){
        //     _canvas.SetActive(false);
        // }
    }
}
