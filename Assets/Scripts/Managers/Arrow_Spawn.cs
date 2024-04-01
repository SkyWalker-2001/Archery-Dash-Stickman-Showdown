using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Spawn : MonoBehaviour
{
    public static Arrow_Spawn arrow_Spawn_Instance;

    [SerializeField] private GameObject arrow_Prefab;
    [SerializeField] private Transform arrow_SpawnPoint;

    [SerializeField] private float shootTime;
                     private float shootTimerCounter;

    private void Awake()
    {
        arrow_Spawn_Instance = this;
    }

    private void Update()
    {
        shootTimerCounter -= Time.deltaTime;
    }

    public void Arrow_Spawn_FN()
    {
        if (shootTimerCounter <= 0)
        {
            shootTimerCounter = shootTime;
            GameObject newArrow = Instantiate(arrow_Prefab, arrow_SpawnPoint.position, arrow_SpawnPoint.rotation);
        }

    }
}
