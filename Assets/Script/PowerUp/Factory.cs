using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Factory : MonoBehaviour
{
    [SerializeField] private PowerUp[] skills;
    private Dictionary<string, PowerUp> skillsByName;

    private void Awake()
    {
        skillsByName = new Dictionary<string, PowerUp>(); foreach (var skill in skills)
        {
            skillsByName.Add(skill.skillName, skill);
        }
    }

    public PowerUp CreatePowerup(string skillName, Transform playerTransform)
    {
        if (skillsByName.TryGetValue(skillName, out PowerUp skillPrefab))
        {
            PowerUp skillInstance = Instantiate(skillPrefab, playerTransform.position, Quaternion.identity);
            return skillInstance;
        }
        else
        {
            Debug.LogWarning($"The ability '{skillName}' does not exist in the skills database.");
            return null;
        }
    }
}
