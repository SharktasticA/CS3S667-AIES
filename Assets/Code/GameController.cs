﻿using UnityEngine;

/// <summary>
/// 
/// </summary>
public class GameController : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    [SerializeField]
    private Vector3 gridSize = new Vector3(20, 0, 20);

    /// <summary>
    /// 
    /// </summary>
    [SerializeField]
    private GameObject[] foliage;

    private void Start()
    {        
        for (int i = 0; i < 5000; i++)
        {
            if (foliage.Length == 0) break;
            
            Vector3 pos = new Vector3(Random.Range(-gridSize.x * 2, gridSize.x * 2), 0, Random.Range(-gridSize.x * 2, gridSize.x * 2));
            Vector3 rot = new Vector3(0, Random.Range(0, 359), 0);
            
            GameObject obj = Instantiate(foliage[Random.Range(0, foliage.Length)], pos, Quaternion.Euler(rot), transform) as GameObject;
          
            obj.transform.localScale = new Vector3(0.04f, 0.04f, 0.04f);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(transform.position, new Vector3(gridSize.x, 1, gridSize.z));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Vector3 GetGridSize() { return gridSize; }
}