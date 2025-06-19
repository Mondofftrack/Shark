using UnityEngine;

public class MobileInput : MonoBehaviour
{
    public bool upPressed, downPressed, leftPressed, rightPressed;

    public void OnPressUp() => upPressed = true;
    public void OnReleaseUp() => upPressed = false;

    public void OnPressDown() => downPressed = true;
    public void OnReleaseDown() => downPressed = false;

    public void OnPressLeft() => leftPressed = true;
    public void OnReleaseLeft() => leftPressed = false;

    public void OnPressRight() => rightPressed = true;
    public void OnReleaseRight() => rightPressed = false;
}
