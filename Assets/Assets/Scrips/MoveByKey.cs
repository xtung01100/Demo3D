using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByKey : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController characterController;
    public float movingspeed;
    private void OnValidate() => characterController = GetComponent<CharacterController>();
    
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        Vector3 direction = transform.right * hInput + transform.forward * vInput;
        characterController.SimpleMove(direction * movingspeed);
    }
}
    