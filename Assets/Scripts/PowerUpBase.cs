using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] protected bool IsEffectActive = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    abstract void ApplyEffect(Player player)
    {

    }
    
}
