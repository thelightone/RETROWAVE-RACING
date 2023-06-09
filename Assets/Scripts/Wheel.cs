using UnityEngine;

public class Wheel : MonoBehaviour
{
    private float TurnSpeed = 60f;
    private float TurnInput;

    void Update()
    {
        TurnInput = Input.GetAxis("Horizontal");
        Vector3 rotate = transform.eulerAngles;
        rotate.z = -TurnInput * TurnSpeed;
        rotate.x = 90;
        rotate.y = 90;
        transform.rotation = Quaternion.Euler(rotate);
    }
}