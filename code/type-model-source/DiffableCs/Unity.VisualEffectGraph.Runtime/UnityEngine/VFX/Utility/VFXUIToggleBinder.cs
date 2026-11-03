namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/UI Toggle Binder")]
[Token(Token = "0x2000063")]
[VFXBinder("UI/Toggle")]
internal class VFXUIToggleBinder : VFXBinderBase
{
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_Parameter")]
	[SerializeField]
	[Token(Token = "0x40001F3")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"System.Boolean"})]
	protected ExposedProperty m_Property; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001F4")]
	public Toggle Target; //Field offset: 0x30

	[Token(Token = "0x1700003B")]
	public string Property
	{
		[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
		[Token(Token = "0x60001D2")]
		 get { } //Length: 27
		[Address(RVA = "0x2F7DD70", Offset = "0x2F7D170", Length = "0x2B")]
		[Token(Token = "0x60001D3")]
		 set { } //Length: 43
	}

	[Address(RVA = "0x2F81DB0", Offset = "0x2F811B0", Length = "0x52")]
	[Token(Token = "0x60001D7")]
	public VFXUIToggleBinder() { }

	[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
	[Token(Token = "0x60001D2")]
	public string get_Property() { }

	[Address(RVA = "0x2F81C00", Offset = "0x2F81000", Length = "0x9C")]
	[Token(Token = "0x60001D4")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F7DD70", Offset = "0x2F7D170", Length = "0x2B")]
	[Token(Token = "0x60001D3")]
	public void set_Property(string value) { }

	[Address(RVA = "0x2F81CA0", Offset = "0x2F810A0", Length = "0xB9")]
	[Token(Token = "0x60001D6")]
	public virtual string ToString() { }

	[Address(RVA = "0x2F81D60", Offset = "0x2F81160", Length = "0x4D")]
	[Token(Token = "0x60001D5")]
	public virtual void UpdateBinding(VisualEffect component) { }

}

