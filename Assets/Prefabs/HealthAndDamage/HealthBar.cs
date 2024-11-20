using UnityEngine;

public class HealthBar : ValueGauge
{
    [SerializeField] GameObject healthCompOwner;
    private void Start()
    {
        SetOwner(healthCompOwner);    
    }
    public override void SetOwner(GameObject newOwner)
    {
        base.SetOwner(newOwner);
        HealthComponent ownerHealthComponent = newOwner.GetComponent<HealthComponent>();
        if (ownerHealthComponent)
        {
            ownerHealthComponent.OnHealthChanged += HealthChanged;
            ownerHealthComponent.OnDead += OwnerDead;
            UpdateValue(ownerHealthComponent.GetHealth(), ownerHealthComponent.GetMaxHealth());
        }
    }

    private void OwnerDead(GameObject killer)
    {
        Destroy(gameObject);
    }

    private void HealthChanged(float newHealth, float delta, float maxHealth, GameObject instigator)
    {
        UpdateValue(newHealth, maxHealth);
    }
}
