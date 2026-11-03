namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/UI Dropdown Binder")]
[Token(Token = "0x2000061")]
[VFXBinder("UI/Dropdown")]
internal class VFXUIDropdownBinder : VFXBinderBase
{
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_Parameter")]
	[SerializeField]
	[Token(Token = "0x40001EF")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"System.Int32"})]
	protected ExposedProperty m_Property; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001F0")]
	public Dropdown Target; //Field offset: 0x30

	[Token(Token = "0x17000039")]
	public string Property
	{
		[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
		[Token(Token = "0x60001C6")]
		 get { } //Length: 27
		[Address(RVA = "0x2F7DD70", Offset = "0x2F7D170", Length = "0x2B")]
		[Token(Token = "0x60001C7")]
		 set { } //Length: 43
	}

	[Address(RVA = "0x2F81970", Offset = "0x2F80D70", Length = "0x52")]
	[Token(Token = "0x60001CB")]
	public VFXUIDropdownBinder() { }

	[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
	[Token(Token = "0x60001C6")]
	public string get_Property() { }

	[Address(RVA = "0x2F817C0", Offset = "0x2F80BC0", Length = "0x9C")]
	[Token(Token = "0x60001C8")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F7DD70", Offset = "0x2F7D170", Length = "0x2B")]
	[Token(Token = "0x60001C7")]
	public void set_Property(string value) { }

	[Address(RVA = "0x2F81860", Offset = "0x2F80C60", Length = "0xB9")]
	[Token(Token = "0x60001CA")]
	public virtual string ToString() { }

	[Address(RVA = "0x2F81920", Offset = "0x2F80D20", Length = "0x4C")]
	[Token(Token = "0x60001C9")]
	public virtual void UpdateBinding(VisualEffect component) { }

}

