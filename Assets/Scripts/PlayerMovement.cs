using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController chcontrol;
    private float speed = 7f;
    // Start is called before the first frame update
    void Start()
    {
        chcontrol = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        chcontrol.Move((Vector3.forward * speed) * Time.deltaTime);
    }
}
