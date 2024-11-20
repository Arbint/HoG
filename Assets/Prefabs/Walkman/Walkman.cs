using UnityEngine;

[RequireComponent(typeof(HealthComponent))]
public class Walkman : MonoBehaviour, ITeamInterface
{
    [SerializeField] int teamId;

    HealthComponent _healthComponent;

    public int GetTeamID()
    {
        return teamId;
    }

    private void Awake()
    {
        _healthComponent = GetComponent<HealthComponent>();
    }
}
