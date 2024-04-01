using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Controller : Player
{
    [SerializeField] private FixedJoystick _joystick;

    [SerializeField] private float weapon_rotation_Speed;

    private void Update()
    {
        Weapon_Position();
    }


    private void Weapon_Position()
    {
        Vector3 mousePosition = new Vector3(_joystick.Horizontal * weapon_rotation_Speed, _joystick.Vertical * weapon_rotation_Speed, 0.0f);

        Vector3 direction = transform.position - mousePosition;

        transform.right = -direction;  
    }
}
