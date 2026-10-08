using UnityEngine;
using UnityEngine.InputSystem;

public class StageMove : MonoBehaviour
{
    private InputAction moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveInput = InputSystem.actions.FindAction("move");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(moveInput.ReadValue<Vector2>());
        this.transform.Rotate((Vector3)moveInput.ReadValue<Vector2>());

    }
}
