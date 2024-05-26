using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerak : MonoBehaviour
{
    public float speed, powerJump, jangkauan;
    float horizontalInput, verticalInput;
    public LayerMask Player;
    public bool tanah;
    public Transform orientation;
    Vector3 pindahArah;
    Rigidbody lompat;

    // Start is called before the first frame update
    void Start()
    {
        lompat = GetComponent<Rigidbody>();
        lompat.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        tanah = Physics.Raycast(transform.position, -Vector3.up, jangkauan);

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Space) && tanah)
        {
            lompat.velocity = new Vector3(lompat.velocity.x, 0f, lompat.velocity.z);
            lompat.AddForce(transform.up * powerJump, ForceMode.Impulse);
        }
        Vector3 flatVel = new Vector3(lompat.velocity.x, 0f, lompat.velocity.z);

        if (flatVel.magnitude > speed)
        {
            Vector3 limitedVel = flatVel.normalized * speed;
            lompat.velocity = new Vector3(limitedVel.x, lompat.velocity.y, limitedVel.z);
        }

        pindahArah = orientation.forward * verticalInput + orientation.right * horizontalInput;
        lompat.AddForce(pindahArah.normalized * speed * 10f, ForceMode.Force);
    }
}
