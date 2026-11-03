namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/Input Axis Binder")]
[Token(Token = "0x200004F")]
[VFXBinder("Input/Axis")]
internal class VFXInputAxisBinder : VFXBinderBase
{
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_AxisParameter")]
	[SerializeField]
	[Token(Token = "0x4000193")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"System.Single"})]
	protected ExposedProperty m_AxisProperty; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000194")]
	public string AxisName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000195")]
	public float AccumulateSpeed; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000196")]
	public bool Accumulate; //Field offset: 0x3C

	[Token(Token = "0x17000022")]
	public string AxisProperty
	{
		[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
		[Token(Token = "0x600013D")]
		 get { } //Length: 27
		[Address(RVA = "0x2F72F60", Offset = "0x2F72360", Length = "0x80")]
		[Token(Token = "0x600013E")]
		 set { } //Length: 128
	}

	[Address(RVA = "0x2F74980", Offset = "0x2F73D80", Length = "0xDC")]
	[Token(Token = "0x6000142")]
	public VFXInputAxisBinder() { }

	[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
	[Token(Token = "0x600013D")]
	public string get_AxisProperty() { }

	[Address(RVA = "0x2F74860", Offset = "0x2F73C60", Length = "0xAA")]
	[Token(Token = "0x600013F")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F72F60", Offset = "0x2F72360", Length = "0x80")]
	[Token(Token = "0x600013E")]
	public void set_AxisProperty(string value) { }

	[Address(RVA = "0x2F74910", Offset = "0x2F73D10", Length = "0x6D")]
	[Token(Token = "0x6000141")]
	public virtual string ToString() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000140")]
	public virtual void UpdateBinding(VisualEffect component) { }

}

