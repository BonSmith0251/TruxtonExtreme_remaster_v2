namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/Light Binder")]
[Token(Token = "0x2000055")]
[VFXBinder("Utility/Light")]
internal class VFXLightBinder : VFXBinderBase
{
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_ColorParameter")]
	[SerializeField]
	[Token(Token = "0x40001B6")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"UnityEngine.Color"})]
	protected ExposedProperty m_ColorProperty; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_BrightnessParameter")]
	[SerializeField]
	[Token(Token = "0x40001B7")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"System.Single"})]
	protected ExposedProperty m_BrightnessProperty; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("m_RadiusParameter")]
	[SerializeField]
	[Token(Token = "0x40001B8")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"System.Single"})]
	protected ExposedProperty m_RadiusProperty; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001B9")]
	public Light Target; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001BA")]
	public bool BindColor; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x40001BB")]
	public bool BindBrightness; //Field offset: 0x49
	[FieldOffset(Offset = "0x4A")]
	[Token(Token = "0x40001BC")]
	public bool BindRadius; //Field offset: 0x4A

	[Token(Token = "0x1700002F")]
	public string BrightnessProperty
	{
		[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
		[Token(Token = "0x6000175")]
		 get { } //Length: 27
		[Address(RVA = "0x2F7DD70", Offset = "0x2F7D170", Length = "0x2B")]
		[Token(Token = "0x6000176")]
		 set { } //Length: 43
	}

	[Token(Token = "0x1700002E")]
	public string ColorProperty
	{
		[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
		[Token(Token = "0x6000173")]
		 get { } //Length: 27
		[Address(RVA = "0x2F7DD70", Offset = "0x2F7D170", Length = "0x2B")]
		[Token(Token = "0x6000174")]
		 set { } //Length: 43
	}

	[Token(Token = "0x17000030")]
	public string RadiusProperty
	{
		[Address(RVA = "0x2F75B90", Offset = "0x2F74F90", Length = "0x1B")]
		[Token(Token = "0x6000177")]
		 get { } //Length: 27
		[Address(RVA = "0x2F7DDA0", Offset = "0x2F7D1A0", Length = "0x2B")]
		[Token(Token = "0x6000178")]
		 set { } //Length: 43
	}

	[Address(RVA = "0x2F7DCC0", Offset = "0x2F7D0C0", Length = "0xAA")]
	[Token(Token = "0x600017C")]
	public VFXLightBinder() { }

	[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
	[Token(Token = "0x6000175")]
	public string get_BrightnessProperty() { }

	[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
	[Token(Token = "0x6000173")]
	public string get_ColorProperty() { }

	[Address(RVA = "0x2F75B90", Offset = "0x2F74F90", Length = "0x1B")]
	[Token(Token = "0x6000177")]
	public string get_RadiusProperty() { }

	[Address(RVA = "0x2F7D9B0", Offset = "0x2F7CDB0", Length = "0x110")]
	[Token(Token = "0x6000179")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F7DD70", Offset = "0x2F7D170", Length = "0x2B")]
	[Token(Token = "0x6000176")]
	public void set_BrightnessProperty(string value) { }

	[Address(RVA = "0x2F7DD70", Offset = "0x2F7D170", Length = "0x2B")]
	[Token(Token = "0x6000174")]
	public void set_ColorProperty(string value) { }

	[Address(RVA = "0x2F7DDA0", Offset = "0x2F7D1A0", Length = "0x2B")]
	[Token(Token = "0x6000178")]
	public void set_RadiusProperty(string value) { }

	[Address(RVA = "0x2F7DAD0", Offset = "0x2F7CED0", Length = "0xB9")]
	[Token(Token = "0x600017B")]
	public virtual string ToString() { }

	[Address(RVA = "0x2F7DB90", Offset = "0x2F7CF90", Length = "0x121")]
	[Token(Token = "0x600017A")]
	public virtual void UpdateBinding(VisualEffect component) { }

}

