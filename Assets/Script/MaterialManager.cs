using UnityEngine;

public class MaterialManager : MonoBehaviour
{
    public static MaterialManager Instance { get; private set; }
    public CustomMaterial customMaterial;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public Material ApplyCustomMaterial(Material material)
    {
        material.color = customMaterial.color;
        material.SetFloat("_Shininess", customMaterial.shininess);
        material.mainTexture = customMaterial.texture;
        return material;
    }
}