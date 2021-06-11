using UnityEngine;

public class Feet : MonoBehaviour 
{
    public bool CollidingOnGround { get; private set;} = false;

    private void OnCollisionEnter2D(Collision2D other) 
    {
        CollidingOnGround = true;
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        CollidingOnGround = false;    
    }
}