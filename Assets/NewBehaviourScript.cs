using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "ScriptableObject/NewBehaviourScript")]
public class NewBehaviourScript : ScriptableObject {
    public string weaponName;
    public Sprite sprite;
    public Color color = Color.white;
    public ColliderType colliderType = ColliderType.None;
 
    public enum ColliderType {
        None = 0,
        Sprite = 1,
        Grid = 2
    }

    
}
