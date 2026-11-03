namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/Enabled Binder")]
[Token(Token = "0x200004A")]
[VFXBinder("GameObject/Enabled")]
internal class VFXEnabledBinder : VFXBinderBase
{
	[Token(Token = "0x200004B")]
	internal enum Check : int
	{
		ActiveInHierarchy = 0,
		ActiveSelf = 1,
	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400017A")]
	public Check check; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_Parameter")]
	[SerializeField]
	[Token(Token = "0x400017B")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"System.Boolean"})]
	protected ExposedProperty m_Property; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400017C")]
	public GameObject Target; //Field offset: 0x38

	[Token(Token = "0x17000021")]
	public string Property
	{
		[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
		[Token(Token = "0x600012E")]
		 get { } //Length: 27
		[Address(RVA = "0x2F72FE0", Offset = "0x2F723E0", Length = "0x80")]
		[Token(Token = "0x600012F")]
		 set { } //Length: 128
	}

	[Address(RVA = "0x2F73350", Offset = "0x2F72750", Length = "0xAA")]
	[Token(Token = "0x6000133")]
	public VFXEnabledBinder() { }

	[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
	[Token(Token = "0x600012E")]
	public string get_Property() { }

	[Address(RVA = "0x2F73060", Offset = "0x2F72460", Length = "0x10D")]
	[Token(Token = "0x6000130")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F72FE0", Offset = "0x2F723E0", Length = "0x80")]
	[Token(Token = "0x600012F")]
	public void set_Property(string value) { }

	[Address(RVA = "0x2F73170", Offset = "0x2F72570", Length = "0xF6")]
	[Token(Token = "0x6000132")]
	public virtual string ToString() { }

	[Address(RVA = "0x2F73270", Offset = "0x2F72670", Length = "0xD9")]
	[Token(Token = "0x6000131")]
	public virtual void UpdateBinding(VisualEffect component) { }

}

