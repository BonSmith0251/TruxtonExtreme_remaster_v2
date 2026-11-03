using UnityEngine;
using UnityEngine.Rendering;

public class TXECameraTextureBinder : MonoBehaviour
{
	[SerializeField]
	private string textureName;

	[SerializeField]
	private Camera targetCamera;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnBeginCameraRendering(ScriptableRenderContext ctx, Camera cam)
	{
	}
}
