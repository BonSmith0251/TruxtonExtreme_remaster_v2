namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/Previous Position Binder")]
[Token(Token = "0x2000059")]
[VFXBinder("Transform/Position (Previous)")]
internal class VFXPreviousPositionBinder : VFXSpaceableBinder
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001C9")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"UnityEngine.Vector3"})]
	public ExposedProperty m_Property; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001CA")]
	public Transform Target; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001CB")]
	private Vector3 oldPosition; //Field offset: 0x40

	[Address(RVA = "0x2F7EEB0", Offset = "0x2F7E2B0", Length = "0x52")]
	[Token(Token = "0x6000196")]
	public VFXPreviousPositionBinder() { }

	[Address(RVA = "0x2F7EBA0", Offset = "0x2F7DFA0", Length = "0x9C")]
	[Token(Token = "0x6000193")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F7EC40", Offset = "0x2F7E040", Length = "0xD6")]
	[Token(Token = "0x6000192")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2F7ED20", Offset = "0x2F7E120", Length = "0xB9")]
	[Token(Token = "0x6000195")]
	public virtual string ToString() { }

	[Address(RVA = "0x2F7EDE0", Offset = "0x2F7E1E0", Length = "0xC4")]
	[Token(Token = "0x6000194")]
	public virtual void UpdateBinding(VisualEffect component) { }

}

