namespace UnityEngine.Rendering;

[Token(Token = "0x20001EC")]
public class TextureGradient : IDisposable
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400095D")]
	private int <textureSize>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400095E")]
	private Gradient m_Gradient; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400095F")]
	private Texture2D m_Texture; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000960")]
	private int m_RequestedTextureSize; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000961")]
	private bool m_IsTextureDirty; //Field offset: 0x2C
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x4000962")]
	private bool m_Precise; //Field offset: 0x2D
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000963")]
	public GradientMode mode; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000964")]
	public ColorSpace colorSpace; //Field offset: 0x34

	[HideInInspector]
	[Token(Token = "0x170001DD")]
	public GradientAlphaKey[] alphaKeys
	{
		[Address(RVA = "0x2C677E0", Offset = "0x2C66BE0", Length = "0x13")]
		[Token(Token = "0x6000EA7")]
		 get { } //Length: 19
	}

	[HideInInspector]
	[Token(Token = "0x170001DC")]
	public GradientColorKey[] colorKeys
	{
		[Address(RVA = "0x2C67800", Offset = "0x2C66C00", Length = "0x13")]
		[Token(Token = "0x6000EA6")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170001DB")]
	public private int textureSize
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000EA4")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000EA5")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2C676D0", Offset = "0x2C66AD0", Length = "0x101")]
	[Token(Token = "0x6000EA8")]
	public TextureGradient(Gradient baseCurve) { }

	[Address(RVA = "0x2C67650", Offset = "0x2C66A50", Length = "0x7C")]
	[Token(Token = "0x6000EA9")]
	public TextureGradient(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys, GradientMode mode = 2, ColorSpace colorSpace = -1, int requestedTextureSize = -1, bool precise = false) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000EAB")]
	public override void Dispose() { }

	[Address(RVA = "0x2C66E00", Offset = "0x2C66200", Length = "0x4D")]
	[Token(Token = "0x6000EB0")]
	public Color Evaluate(float time) { }

	[Address(RVA = "0x2C677E0", Offset = "0x2C66BE0", Length = "0x13")]
	[Token(Token = "0x6000EA7")]
	public GradientAlphaKey[] get_alphaKeys() { }

	[Address(RVA = "0x2C67800", Offset = "0x2C66C00", Length = "0x13")]
	[Token(Token = "0x6000EA6")]
	public GradientColorKey[] get_colorKeys() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000EA4")]
	public int get_textureSize() { }

	[Address(RVA = "0x2C66E50", Offset = "0x2C66250", Length = "0x2DA")]
	[Token(Token = "0x6000EAF")]
	public Texture2D GetTexture() { }

	[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
	[Token(Token = "0x6000EAE")]
	private static GraphicsFormat GetTextureFormat() { }

	[Address(RVA = "0x2C67130", Offset = "0x2C66530", Length = "0x3B8")]
	[Token(Token = "0x6000EAA")]
	private void Rebuild(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys, GradientMode mode, ColorSpace colorSpace, int requestedTextureSize, bool precise) { }

	[Address(RVA = "0x2C674F0", Offset = "0x2C668F0", Length = "0x9F")]
	[Token(Token = "0x6000EAC")]
	public void Release() { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000EA5")]
	private void set_textureSize(int value) { }

	[Address(RVA = "0x2C67590", Offset = "0x2C66990", Length = "0x5")]
	[Token(Token = "0x6000EAD")]
	public void SetDirty() { }

	[Address(RVA = "0x2C675A0", Offset = "0x2C669A0", Length = "0xAE")]
	[Token(Token = "0x6000EB1")]
	public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys, GradientMode mode, ColorSpace colorSpace) { }

}

