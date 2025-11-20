using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField] private Transform cameraPos;

    private void Update()
    {
        transform.position = cameraPos.position;
    }
}
