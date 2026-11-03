namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/UI Slider Binder")]
[Token(Token = "0x2000062")]
[VFXBinder("UI/Slider")]
internal class VFXUISliderBinder : VFXBinderBase
{
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_Parameter")]
	[SerializeField]
	[Token(Token = "0x40001F1")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"System.Single"})]
	protected ExposedProperty m_Property; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001F2")]
	public Slider Target; //Field offset: 0x30

	[Token(Token = "0x1700003A")]
	public string Property
	{
		[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
		[Token(Token = "0x60001CC")]
		 get { } //Length: 27
		[Address(RVA = "0x2F7DD70", Offset = "0x2F7D170", Length = "0x2B")]
		[Token(Token = "0x60001CD")]
		 set { } //Length: 43
	}

	[Address(RVA = "0x2F81BA0", Offset = "0x2F80FA0", Length = "0x52")]
	[Token(Token = "0x60001D1")]
	public VFXUISliderBinder() { }

	[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
	[Token(Token = "0x60001CC")]
	public string get_Property() { }

	[Address(RVA = "0x2F819D0", Offset = "0x2F80DD0", Length = "0x9C")]
	[Token(Token = "0x60001CE")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F7DD70", Offset = "0x2F7D170", Length = "0x2B")]
	[Token(Token = "0x60001CD")]
	public void set_Property(string value) { }

	[Address(RVA = "0x2F81A70", Offset = "0x2F80E70", Length = "0xB9")]
	[Token(Token = "0x60001D0")]
	public virtual string ToString() { }

	[Address(RVA = "0x2F81B30", Offset = "0x2F80F30", Length = "0x68")]
	[Token(Token = "0x60001CF")]
	public virtual void UpdateBinding(VisualEffect component) { }

}

