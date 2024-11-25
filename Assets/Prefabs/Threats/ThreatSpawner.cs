using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class ThreatSpawnHandler
{
    [SerializeField] Threat ThreatPrefab;
    [SerializeField] int maxCount = 10;
    [SerializeField] float spawnInterval = 3f;

    int _currentCount = 0;
    public void Start(MonoBehaviour owner)
    {
        owner.StartCoroutine(SpawnCoroutine());
    }

    IEnumerator SpawnCoroutine()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnInterval);
            if(_currentCount < maxCount)
            {
                Threat newThreat = GameObject.Instantiate(ThreatPrefab);
                _currentCount++;
                newThreat.onDead += () => _currentCount--;
            }
        }
    }
}

public class ThreatSpawner : MonoBehaviour
{
    [SerializeField] ThreatSpawnHandler[] threatSpawnHandlers;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       foreach(ThreatSpawnHandler spawnHandler in threatSpawnHandlers)
        {
            spawnHandler.Start(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
