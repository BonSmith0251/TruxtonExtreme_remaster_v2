namespace Unity.Cinemachine;

[Obsolete("LegacyLensSettings is deprecated. Use LensSettings instead.")]
[Token(Token = "0x200013F")]
public struct LegacyLensSettings
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400053D")]
	public float FieldOfView; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400053E")]
	public float OrthographicSize; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400053F")]
	public float NearClipPlane; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000540")]
	public float FarClipPlane; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000541")]
	public float Dutch; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000542")]
	public OverrideModes ModeOverride; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000543")]
	public GateFitMode GateFit; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	[Token(Token = "0x4000544")]
	public Vector2 m_SensorSize; //Field offset: 0x1C
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000545")]
	public Vector2 LensShift; //Field offset: 0x24
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000546")]
	public float FocusDistance; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000547")]
	public int Iso; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000548")]
	public float ShutterSpeed; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000549")]
	public float Aperture; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400054A")]
	public int BladeCount; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400054B")]
	public Vector2 Curvature; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400054C")]
	public float BarrelClipping; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400054D")]
	public float Anamorphism; //Field offset: 0x4C

	[Token(Token = "0x1700013E")]
	public static LegacyLensSettings Default
	{
		[Address(RVA = "0x287ED30", Offset = "0x287E130", Length = "0xD3")]
		[Token(Token = "0x6000641")]
		 get { } //Length: 211
	}

	[Address(RVA = "0x287ED30", Offset = "0x287E130", Length = "0xD3")]
	[Token(Token = "0x6000641")]
	public static LegacyLensSettings get_Default() { }

	[Address(RVA = "0x287EA20", Offset = "0x287DE20", Length = "0x65")]
	[Token(Token = "0x600063F")]
	public void SetFromLensSettings(LensSettings src) { }

	[Address(RVA = "0x287EA90", Offset = "0x287DE90", Length = "0x15C")]
	[Token(Token = "0x600063E")]
	public LensSettings ToLensSettings() { }

	[Address(RVA = "0x287EBF0", Offset = "0x287DFF0", Length = "0x135")]
	[Token(Token = "0x6000640")]
	public void Validate() { }

}

