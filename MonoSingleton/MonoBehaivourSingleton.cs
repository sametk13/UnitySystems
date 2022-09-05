using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaivourSingleton<T> : MonoBehaviour
     where T : Component
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                var objects = FindObjectsOfType(typeof(T), true) as T[];

                if (objects.Length > 1)
                {
                    Debug.LogError($"Singleton class can not have more than one. : {typeof(T).Name}");
                }
                else if (objects.Length == 1)
                {
                    instance = objects[0];
                }
                Debug.LogError($"{typeof(T).Name} is null");
            }

            return instance;
        }
    }
}
