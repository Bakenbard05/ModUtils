using UnityEngine;
public class RSMod : MonoBehaviour
{
    public virtual void Cleanup()
    {
        if (gameObject != null)
        {
            Destroy(gameObject);
        }
    }
}