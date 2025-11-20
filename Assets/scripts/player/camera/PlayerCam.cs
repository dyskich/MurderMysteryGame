using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class PlayerCam : MonoBehaviour
{
    [SerializeField] private float sensitivity;

    [SerializeField] private Transform orientation;

    float xRot;
    float yRot;

    private InputAction input;

    private void Start()
    {
        input = InputSystem.actions.FindAction("Look");

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        //get mouse input
        Vector2 mouseInput = input.ReadValue<Vector2>() * sensitivity / 10;

        yRot += mouseInput.x;
        xRot -= mouseInput.y;
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        //rotate cam and orientation
        transform.rotation = Quaternion.Euler(xRot, yRot, 0);
        orientation.rotation = Quaternion.Euler(0, yRot, 0);
    }
}
