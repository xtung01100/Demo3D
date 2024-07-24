using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateByMouse : MonoBehaviour
{
    // Start is called before the first frame update
    public float angleOverdistance;
    public Transform cameraHolder;
    public float minPitch;
    public float maxPitch;

    private float pitch;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void Update()
    {
        UpdateYaw();
        UpdatePitch();
    }

    // Update is called once per frame
    private void UpdateYaw()
    {
        float mouseX = Input.GetAxis("Mouse X");

        float deltaYaw = mouseX * angleOverdistance;
        transform.Rotate(0, deltaYaw, 0);
        
    }
    private void UpdatePitch()
    {
        float mouseY = Input.GetAxis("Mouse Y");
        float deltaPitch = -mouseY * angleOverdistance;
        pitch = Mathf.Clamp(pitch + deltaPitch, minPitch, maxPitch);
        cameraHolder.localEulerAngles = new Vector3(pitch, 0, 0);
    }
        
    
}
