using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    public Transform cameraPlayer;
    public Camera Camera0, Camera1, Camera2;

    // Start is called before the first frame update
    void Start()
    {
        Camera0.enabled = true;
        Camera1.enabled = false;
        Camera2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cameraPlayer.position;

        if (Input.GetKey(KeyCode.I))
        {
            CameraAktif();
            Camera0.enabled = true;
        }
        else if (Input.GetKey(KeyCode.O))
        {
            CameraAktif();
            Camera1.enabled = true;
        }
        else if (Input.GetKey(KeyCode.P))
        {
            CameraAktif();
            Camera2.enabled = true;
        }
    }

    public void CameraAktif()
    {
        Camera0.enabled = false;
        Camera1.enabled = false;
        Camera2.enabled = false;
    }
}
