using UnityEngine;

public class timeDestroy : MonoBehaviour
{
    public float aliveTimer;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, aliveTimer);
    }
}
