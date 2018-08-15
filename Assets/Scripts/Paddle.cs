using UnityEngine;

/// <summary>
/// 
/// </summary>
public class Paddle : MonoBehaviour 
{
    public PaddleSide Side;

    public enum PaddleSide { LEFT, RIGHT };

    private float inputFloat;

    void Update()
    {
        if (Side == PaddleSide.LEFT)
        {
            inputFloat = Input.GetAxis("LeftPaddle");
        }
        else if (Side == PaddleSide.RIGHT)
        {
            inputFloat = Input.GetAxis("RightPaddle");
        }

        transform.Translate(Vector3.up * inputFloat * Time.deltaTime, Camera.main.transform);
    }
}
