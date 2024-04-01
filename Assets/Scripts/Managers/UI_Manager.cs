using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public void Attack_Button()
    {
        Arrow_Spawn.arrow_Spawn_Instance.Arrow_Spawn_FN();
    }
}
