using UnityEngine;

public class CameraSeguirObjetivo : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void LateUpdate()
    {
        if (_target != null)
        {
            transform.position = new Vector3(_target.position.x, transform.position.y, transform.position.z);
        }
    }
}