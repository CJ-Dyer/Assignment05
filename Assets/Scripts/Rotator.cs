using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(PlayerSettings.RotatorSpeed, PlayerSettings.RotatorSpeed, PlayerSettings.RotatorSpeed) * Time.deltaTime);
    }
}
