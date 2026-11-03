namespace UnityEngine.VFX.Utility;

[RequireComponent(typeof(Renderer))]
[Token(Token = "0x2000043")]
internal class VFXVisibilityEventBinder : VFXEventBinderBase
{
	[Token(Token = "0x2000044")]
	internal enum Activation : int
	{
		OnBecameVisible = 0,
		OnBecameInvisible = 1,
	}

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000162")]
	public Activation activation; //Field offset: 0x38

	[Address(RVA = "0x2F73560", Offset = "0x2F72960", Length = "0x4F")]
	[Token(Token = "0x600010F")]
	public VFXVisibilityEventBinder() { }

	[Address(RVA = "0x2F78E40", Offset = "0x2F78240", Length = "0x50")]
	[Token(Token = "0x600010E")]
	private void OnBecameInvisible() { }

	[Address(RVA = "0x2F78E90", Offset = "0x2F78290", Length = "0x50")]
	[Token(Token = "0x600010D")]
	private void OnBecameVisible() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600010C")]
	protected virtual void SetEventAttribute(Object[] parameters) { }

}

