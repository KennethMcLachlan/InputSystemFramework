using Game.Scripts.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private Player _player;

    private PlayerInputActions _input;
    void Start()
    {
        
    }

    void Update()
    {
        var move = _input.Player.Movement.ReadValue<Vector2>();
        
        
    }
}
