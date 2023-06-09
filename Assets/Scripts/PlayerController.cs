using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private float _speed = 10f;
    private float _TurnSpeed = 40f;
    private float _TurnInput;
    private float _ForwardInput;
    protected Rigidbody _r;
    private Vector3 _CoM;
    private bool _Awake;

    void Start()
    {
        _r = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _TurnInput = Input.GetAxis("Horizontal");
        _ForwardInput = 1 + Input.GetAxis("Vertical");
        _CoM.z = _TurnInput / 3;
        _CoM.y = 0;
        _CoM.x = 0;
        _r.centerOfMass = _CoM;
        _r.WakeUp();
        _Awake = !_r.IsSleeping();

        if (transform.position.y > 5)
            return;
        transform.Translate(Vector3.right * Time.deltaTime * _speed * _ForwardInput);

        Vector3 rotate = transform.eulerAngles;
        rotate.y = -90 + _TurnInput * _TurnSpeed;
        transform.rotation = Quaternion.Euler(rotate);
    }
}
