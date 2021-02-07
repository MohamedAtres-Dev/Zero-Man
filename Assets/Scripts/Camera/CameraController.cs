using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject _player = default;

    [SerializeField] private Vector3 offset = default;
    private void Awake()
    {
        _player = FindObjectOfType<PlayerController>().gameObject;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = _player.transform.position + offset;
    }
}
