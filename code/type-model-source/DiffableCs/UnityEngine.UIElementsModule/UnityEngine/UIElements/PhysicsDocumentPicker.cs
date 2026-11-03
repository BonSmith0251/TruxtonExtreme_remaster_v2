namespace UnityEngine.UIElements;

[Token(Token = "0x200026B")]
internal class PhysicsDocumentPicker
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60010E1")]
	public PhysicsDocumentPicker() { }

	[Address(RVA = "0x33F1CF0", Offset = "0x33F10F0", Length = "0x1E2")]
	[Token(Token = "0x60010E0")]
	private bool GetCapturingDocument(int pointerId, out UIDocument capturingDocument) { }

	[Address(RVA = "0x33F1EE0", Offset = "0x33F12E0", Length = "0xAD")]
	[Token(Token = "0x60010DE")]
	private void Pick(Ray worldRay, float maxDistance, int layerMask, out Collider collider, out UIDocument document, out VisualElement pickedElement, out float distance) { }

	[Address(RVA = "0x33F1F90", Offset = "0x33F1390", Length = "0x25E")]
	[Token(Token = "0x60010DF")]
	public bool TryPickWithCapture(int pointerId, Ray worldRay, float maxDistance, int layerMask, out Collider collider, out UIDocument document, out VisualElement elementUnderPointer, out float distance, out bool captured) { }

}

