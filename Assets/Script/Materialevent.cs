using UnityEngine;
using UnityEngine.Events;

public class MaterialEvent : UnityEvent<Material> { }

public class MaterialUpdater : MonoBehaviour
{
    public Material material;
    public MaterialEvent onMaterialUpdate;

    private void Start()
    {
        if (onMaterialUpdate == null)
            onMaterialUpdate = new MaterialEvent();

        onMaterialUpdate.AddListener(UpdateMaterial);
    }

    private void UpdateMaterial(Material newMaterial)
    {
        GetComponent<Renderer>().material = newMaterial;
    }

    public void ApplyMaterial()
    {
        Material updatedMaterial = MaterialManager.Instance.ApplyCustomMaterial(material);
        onMaterialUpdate.Invoke(updatedMaterial);
    }
}
