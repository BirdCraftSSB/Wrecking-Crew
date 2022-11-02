using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Reflection;
using System;
using TMPro;

public class EnemyFactory : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;

    public GameObject buttonPanel;
    public GameObject buttonPrefab;

    List<Enemy2> enemies;

    // Start is called before the first frame update
    void Start()
    {
        var enemyTypes = Assembly.GetAssembly(typeof(Enemy2)).GetTypes().Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Enemy2)));

        enemies = new List<Enemy2>();

        foreach(var type in enemyTypes)
        {
            var tempType = Activator.CreateInstance(type) as Enemy2;
            enemies.Add(tempType);
        }

        ButtonPanel();
    }

    public Enemy2 GetEnemy(string enemyType)
    {
        foreach(Enemy2 enemy in enemies)
        {
            if(enemy.Name == enemyType)
            {
                Debug.Log("Enemy found!");
                var target = Activator.CreateInstance(enemy.GetType()) as Enemy2;

                return target;
            }
        }

        return null;
    }

    void ButtonPanel()
    {
        foreach(Enemy2 enemy in enemies)
        {
            var button = Instantiate(buttonPrefab);
            button.transform.SetParent(buttonPanel.transform);
            button.gameObject.name = enemy.Name + " Button ";
            button.GetComponentInChildren<TextMeshProUGUI>().text = enemy.Name;
        }
    }
}
