using UnityEngine;

[CreateAssetMenu(fileName = "CustomMaterial", menuName = "ScriptableObjects/CustomMaterial", order = 1)]
public class CustomMaterial : ScriptableObject
{
    public Color color;
    public float shininess;
    public Texture texture;
}