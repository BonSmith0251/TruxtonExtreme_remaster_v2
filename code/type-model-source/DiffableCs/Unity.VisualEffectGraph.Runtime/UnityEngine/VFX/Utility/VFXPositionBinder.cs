namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/Position Binder")]
[Token(Token = "0x2000058")]
[VFXBinder("Transform/Position")]
internal class VFXPositionBinder : VFXSpaceableBinder
{
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40001C7")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"UnityEditor.VFX.Position", "UnityEngine.Vector3"})]
	protected ExposedProperty m_Property; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001C8")]
	public Transform Target; //Field offset: 0x38

	[Token(Token = "0x17000032")]
	public string Property
	{
		[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
		[Token(Token = "0x600018C")]
		 get { } //Length: 27
		[Address(RVA = "0x2F7EB70", Offset = "0x2F7DF70", Length = "0x2B")]
		[Token(Token = "0x600018D")]
		 set { } //Length: 43
	}

	[Address(RVA = "0x2F7EB10", Offset = "0x2F7DF10", Length = "0x52")]
	[Token(Token = "0x6000191")]
	public VFXPositionBinder() { }

	[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
	[Token(Token = "0x600018C")]
	public string get_Property() { }

	[Address(RVA = "0x2F7E8D0", Offset = "0x2F7DCD0", Length = "0x9C")]
	[Token(Token = "0x600018E")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F7EB70", Offset = "0x2F7DF70", Length = "0x2B")]
	[Token(Token = "0x600018D")]
	public void set_Property(string value) { }

	[Address(RVA = "0x2F7E970", Offset = "0x2F7DD70", Length = "0xB9")]
	[Token(Token = "0x6000190")]
	public virtual string ToString() { }

	[Address(RVA = "0x2F7EA30", Offset = "0x2F7DE30", Length = "0xD1")]
	[Token(Token = "0x600018F")]
	public virtual void UpdateBinding(VisualEffect component) { }

}

