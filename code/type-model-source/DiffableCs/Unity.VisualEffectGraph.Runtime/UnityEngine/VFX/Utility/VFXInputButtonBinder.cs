namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/Input Button Binder")]
[Token(Token = "0x2000050")]
[VFXBinder("Input/Button")]
internal class VFXInputButtonBinder : VFXBinderBase
{
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_ButtonParameter")]
	[SerializeField]
	[Token(Token = "0x4000197")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"System.Boolean"})]
	protected ExposedProperty m_ButtonProperty; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_ButtonSmoothParameter")]
	[SerializeField]
	[Token(Token = "0x4000198")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"System.Single"})]
	protected ExposedProperty m_ButtonSmoothProperty; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000199")]
	public string ButtonName; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400019A")]
	public float SmoothSpeed; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400019B")]
	public bool UseButtonSmooth; //Field offset: 0x44

	[Token(Token = "0x17000023")]
	public string ButtonProperty
	{
		[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
		[Token(Token = "0x6000143")]
		 get { } //Length: 27
		[Address(RVA = "0x2F72F60", Offset = "0x2F72360", Length = "0x80")]
		[Token(Token = "0x6000144")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000024")]
	public string ButtonSmoothProperty
	{
		[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
		[Token(Token = "0x6000145")]
		 get { } //Length: 27
		[Address(RVA = "0x2F72FE0", Offset = "0x2F723E0", Length = "0x80")]
		[Token(Token = "0x6000146")]
		 set { } //Length: 128
	}

	[Address(RVA = "0x2F74C50", Offset = "0x2F74050", Length = "0x14B")]
	[Token(Token = "0x600014B")]
	public VFXInputButtonBinder() { }

	[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
	[Token(Token = "0x6000143")]
	public string get_ButtonProperty() { }

	[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
	[Token(Token = "0x6000145")]
	public string get_ButtonSmoothProperty() { }

	[Address(RVA = "0x2F74A60", Offset = "0x2F73E60", Length = "0x17C")]
	[Token(Token = "0x6000147")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F72F60", Offset = "0x2F72360", Length = "0x80")]
	[Token(Token = "0x6000144")]
	public void set_ButtonProperty(string value) { }

	[Address(RVA = "0x2F72FE0", Offset = "0x2F723E0", Length = "0x80")]
	[Token(Token = "0x6000146")]
	public void set_ButtonSmoothProperty(string value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000148")]
	private void Start() { }

	[Address(RVA = "0x2F74BE0", Offset = "0x2F73FE0", Length = "0x6D")]
	[Token(Token = "0x600014A")]
	public virtual string ToString() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000149")]
	public virtual void UpdateBinding(VisualEffect component) { }

}

