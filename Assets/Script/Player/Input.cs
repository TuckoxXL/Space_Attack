using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Input : MonoBehaviour
{
    private Controler input;
    [SerializeField] private Player player;
    private Vector2 moved;
    public Vector2 Moved { get { return moved; } }

    private void Awake()
    {
        AwakeMetod();
    }

    private void AwakeMetod()
    {
        input = new Controler();
    }

    private void OnEnable()
    {
        input.Enable();
        input.PlayerControler.Move.performed += OnMovent;
        input.PlayerControler.Shoot.performed += OnShoot;

    }
    private void OnDisable()
    {
        input.Disable();
        input.PlayerControler.Move.performed -= OnMovent;
        input.PlayerControler.Shoot.performed -= OnShoot;
    }

    private void OnMovent(InputAction.CallbackContext value)
    {
        moved = value.ReadValue<Vector2>();
    }

    private void OnShoot(InputAction.CallbackContext value)
    {
        player.Shoot();
    }
}
