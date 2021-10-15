using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float direction;
    public float speed;

    void Update()
    {
        direction = Input.GetAxisRaw("Vertical") * speed;
    }
    void FixedUpdate()
    {
        transform.Translate(new Vector3(0,direction,0));
    }
}
