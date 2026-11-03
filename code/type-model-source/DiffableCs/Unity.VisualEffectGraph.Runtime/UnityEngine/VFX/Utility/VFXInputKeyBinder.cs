namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/Input Key Press Binder")]
[Token(Token = "0x2000051")]
[VFXBinder("Input/Key")]
internal class VFXInputKeyBinder : VFXBinderBase
{
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_KeyParameter")]
	[SerializeField]
	[Token(Token = "0x400019C")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"System.Boolean"})]
	protected ExposedProperty m_KeyProperty; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_KeySmoothParameter")]
	[SerializeField]
	[Token(Token = "0x400019D")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"System.Single"})]
	protected ExposedProperty m_KeySmoothProperty; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400019E")]
	public KeyCode Key; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400019F")]
	public float SmoothSpeed; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001A0")]
	public bool UseKeySmooth; //Field offset: 0x40

	[Token(Token = "0x17000025")]
	public string KeyProperty
	{
		[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
		[Token(Token = "0x600014C")]
		 get { } //Length: 27
		[Address(RVA = "0x2F72F60", Offset = "0x2F72360", Length = "0x80")]
		[Token(Token = "0x600014D")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000026")]
	public string KeySmoothProperty
	{
		[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
		[Token(Token = "0x600014E")]
		 get { } //Length: 27
		[Address(RVA = "0x2F72FE0", Offset = "0x2F723E0", Length = "0x80")]
		[Token(Token = "0x600014F")]
		 set { } //Length: 128
	}

	[Address(RVA = "0x2F74FB0", Offset = "0x2F743B0", Length = "0x12B")]
	[Token(Token = "0x6000154")]
	public VFXInputKeyBinder() { }

	[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
	[Token(Token = "0x600014C")]
	public string get_KeyProperty() { }

	[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
	[Token(Token = "0x600014E")]
	public string get_KeySmoothProperty() { }

	[Address(RVA = "0x2F74DA0", Offset = "0x2F741A0", Length = "0x17C")]
	[Token(Token = "0x6000150")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F72F60", Offset = "0x2F72360", Length = "0x80")]
	[Token(Token = "0x600014D")]
	public void set_KeyProperty(string value) { }

	[Address(RVA = "0x2F72FE0", Offset = "0x2F723E0", Length = "0x80")]
	[Token(Token = "0x600014F")]
	public void set_KeySmoothProperty(string value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000151")]
	private void Start() { }

	[Address(RVA = "0x2F74F20", Offset = "0x2F74320", Length = "0x81")]
	[Token(Token = "0x6000153")]
	public virtual string ToString() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000152")]
	public virtual void UpdateBinding(VisualEffect component) { }

}

