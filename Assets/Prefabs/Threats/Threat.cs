using System;
using UnityEngine;

[RequireComponent(typeof(HealthComponent))]
public abstract class Threat : MonoBehaviour, ITeamInterface, IGrabbable
{
    public Action onDead;
    [SerializeField] int teamId = 1;
    [SerializeField] Transform deathVFXTransform;
    [SerializeField] GameObject deadVFXPrefab;
    [SerializeField] float deadVFXScale = 1;
    HealthComponent _healthComponent;

    protected virtual void Awake()
    {
        _healthComponent = GetComponent<HealthComponent>();
        _healthComponent.OnDead += Blowup;
    }

    protected virtual void Blowup(GameObject killer)
    {
        GameObject deadVFX = Instantiate(deadVFXPrefab, deathVFXTransform.position, deathVFXTransform.rotation);
        deadVFX.transform.localScale = Vector3.one * deadVFXScale;
        Destroy(gameObject);
    }

    protected virtual void OnDestroy()
    {
        onDead?.Invoke(); 
    }

    public int GetTeamID()
    {
        return teamId;
    }

    public abstract void GrabbedBy(GameObject grabber, Vector3 grabPoint);

    public abstract void Released();
} 