using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCont : MonoBehaviour
{
    [Header("追蹤速度"), Range(0, 50)]
    public float speed = 1.5f;
    [Header("上下邊界")]
    public Vector2 LimitY = new Vector2(-5, 5);
    [Header("左右邊界")]
    public Vector2 LimitX = new Vector2(-5, 5);
}
