using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleController : MonoBehaviour
{
    public float speed = 5;

    void Update()
    {
        var moveInput = Input.GetAxis("Vertical");
        var newPosition = transform.position + moveInput * speed * Time.deltaTime * Vector3.up;

        newPosition.y = Mathf.Clamp(newPosition.y, -4.5f, 4.5f);
        transform.position = newPosition;
    }
}
