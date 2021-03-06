using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    public float _speed = 3.5f;
    public float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);

        horizontalInput = Input.GetAxis("Horizontal");
    }
}
