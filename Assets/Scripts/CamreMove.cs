using UnityEngine;

public class CamreMove : MonoBehaviour
{
    private Vector3 _offset = new Vector3(0, 0.6f, -1.35f);

    [SerializeField]
    private GameObject _player;

    void LateUpdate()
    {
        transform.position = _player.transform.position + _offset;
    }
}
