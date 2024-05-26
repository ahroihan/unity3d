using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCam : MonoBehaviour
{
    public float sensX, sensY;

    public Transform orientasi;

    float xRotasi, yRotasi;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * sensY;

        yRotasi += mouseX;
        xRotasi -= mouseY;
        xRotasi = Mathf.Clamp(xRotasi, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotasi, yRotasi, 0);
        orientasi.rotation = Quaternion.Euler(0, yRotasi, 0);
    }
}
