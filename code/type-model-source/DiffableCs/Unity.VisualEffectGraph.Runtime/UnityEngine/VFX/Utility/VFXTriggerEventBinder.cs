namespace UnityEngine.VFX.Utility;

[RequireComponent(typeof(Collider))]
[Token(Token = "0x2000041")]
internal class VFXTriggerEventBinder : VFXEventBinderBase
{
	[Token(Token = "0x2000042")]
	internal enum Activation : int
	{
		OnEnter = 0,
		OnExit = 1,
		OnStay = 2,
	}

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400015B")]
	public List<Collider> colliders; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400015C")]
	public Activation activation; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400015D")]
	private ExposedProperty positionParameter; //Field offset: 0x48

	[Address(RVA = "0x2F78D10", Offset = "0x2F78110", Length = "0x127")]
	[Token(Token = "0x600010B")]
	public VFXTriggerEventBinder() { }

	[Address(RVA = "0x2F788C0", Offset = "0x2F77CC0", Length = "0xE0")]
	[Token(Token = "0x6000108")]
	private void OnTriggerEnter(Collider other) { }

	[Address(RVA = "0x2F789B0", Offset = "0x2F77DB0", Length = "0xE0")]
	[Token(Token = "0x6000109")]
	private void OnTriggerExit(Collider other) { }

	[Address(RVA = "0x2F78AA0", Offset = "0x2F77EA0", Length = "0xE0")]
	[Token(Token = "0x600010A")]
	private void OnTriggerStay(Collider other) { }

	[Address(RVA = "0x2F78B90", Offset = "0x2F77F90", Length = "0x176")]
	[Token(Token = "0x6000107")]
	protected virtual void SetEventAttribute(Object[] parameters) { }

}

