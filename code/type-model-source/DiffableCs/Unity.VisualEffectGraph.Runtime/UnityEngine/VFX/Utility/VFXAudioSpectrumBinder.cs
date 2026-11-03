namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/Audio Spectrum Binder")]
[Token(Token = "0x2000048")]
[VFXBinder("Audio/Audio Spectrum to AttributeMap")]
internal class VFXAudioSpectrumBinder : VFXBinderBase
{
	[Token(Token = "0x2000049")]
	internal enum AudioSourceMode : int
	{
		AudioSource = 0,
		AudioListener = 1,
	}

	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_CountParameter")]
	[SerializeField]
	[Token(Token = "0x400016E")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"System.UInt32"})]
	protected ExposedProperty m_CountProperty; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_TextureParameter")]
	[SerializeField]
	[Token(Token = "0x400016F")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"UnityEngine.Texture2D"})]
	protected ExposedProperty m_TextureProperty; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000170")]
	public FFTWindow FFTWindow; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000171")]
	public uint Samples; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000172")]
	public AudioSourceMode Mode; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000173")]
	public AudioSource AudioSource; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000174")]
	private Texture2D m_Texture; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000175")]
	private Single[] m_AudioCache; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000176")]
	private Color[] m_ColorCache; //Field offset: 0x60

	[Token(Token = "0x1700001F")]
	public string CountProperty
	{
		[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
		[Token(Token = "0x6000125")]
		 get { } //Length: 27
		[Address(RVA = "0x2F72F60", Offset = "0x2F72360", Length = "0x80")]
		[Token(Token = "0x6000126")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000020")]
	public string TextureProperty
	{
		[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
		[Token(Token = "0x6000127")]
		 get { } //Length: 27
		[Address(RVA = "0x2F72FE0", Offset = "0x2F723E0", Length = "0x80")]
		[Token(Token = "0x6000128")]
		 set { } //Length: 128
	}

	[Address(RVA = "0x2F72E30", Offset = "0x2F72230", Length = "0x127")]
	[Token(Token = "0x600012D")]
	public VFXAudioSpectrumBinder() { }

	[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
	[Token(Token = "0x6000125")]
	public string get_CountProperty() { }

	[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
	[Token(Token = "0x6000127")]
	public string get_TextureProperty() { }

	[Address(RVA = "0x2F729D0", Offset = "0x2F71DD0", Length = "0xC2")]
	[Token(Token = "0x6000129")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F72F60", Offset = "0x2F72360", Length = "0x80")]
	[Token(Token = "0x6000126")]
	public void set_CountProperty(string value) { }

	[Address(RVA = "0x2F72FE0", Offset = "0x2F723E0", Length = "0x80")]
	[Token(Token = "0x6000128")]
	public void set_TextureProperty(string value) { }

	[Address(RVA = "0x2F72AA0", Offset = "0x2F71EA0", Length = "0x69")]
	[Token(Token = "0x600012C")]
	public virtual string ToString() { }

	[Address(RVA = "0x2F72B10", Offset = "0x2F71F10", Length = "0x63")]
	[Token(Token = "0x600012B")]
	public virtual void UpdateBinding(VisualEffect component) { }

	[Address(RVA = "0x2F72B80", Offset = "0x2F71F80", Length = "0x2A7")]
	[Token(Token = "0x600012A")]
	private void UpdateTexture() { }

}

