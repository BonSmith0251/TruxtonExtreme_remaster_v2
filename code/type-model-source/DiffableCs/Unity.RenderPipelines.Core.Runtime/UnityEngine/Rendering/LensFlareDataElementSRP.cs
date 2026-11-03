namespace UnityEngine.Rendering;

[Token(Token = "0x200015A")]
public sealed class LensFlareDataElementSRP
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006A6")]
	public LensFlareDataSRP lensFlareDataSRP; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006A7")]
	public bool visible; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40006A8")]
	public float position; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006A9")]
	public Vector2 positionOffset; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006AA")]
	public float angularOffset; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40006AB")]
	public Vector2 translationScale; //Field offset: 0x2C
	[FieldOffset(Offset = "0x34")]
	[Range(0, 1)]
	[Token(Token = "0x40006AC")]
	public float ringThickness; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Range(-1, 1)]
	[Token(Token = "0x40006AD")]
	public float hoopFactor; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40006AE")]
	public float noiseAmplitude; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40006AF")]
	public int noiseFrequency; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40006B0")]
	public float noiseSpeed; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40006B1")]
	public float shapeCutOffSpeed; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40006B2")]
	public float shapeCutOffRadius; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[FormerlySerializedAs("localIntensity")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x40006B3")]
	private float m_LocalIntensity; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40006B4")]
	public Texture lensFlareTexture; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40006B5")]
	public float uniformScale; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40006B6")]
	public Vector2 sizeXY; //Field offset: 0x64
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40006B7")]
	public bool allowMultipleElement; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[FormerlySerializedAs("count")]
	[Min(1)]
	[SerializeField]
	[Token(Token = "0x40006B8")]
	private int m_Count; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40006B9")]
	public bool preserveAspectRatio; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40006BA")]
	public float rotation; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40006BB")]
	public SRPLensFlareColorType tintColorType; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40006BC")]
	public Color tint; //Field offset: 0x80
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40006BD")]
	public TextureGradient tintGradient; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40006BE")]
	public SRPLensFlareBlendMode blendMode; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40006BF")]
	public bool autoRotate; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40006C0")]
	public SRPLensFlareType flareType; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x40006C1")]
	public bool modulateByLightColor; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA5")]
	[SerializeField]
	[Token(Token = "0x40006C2")]
	private bool isFoldOpened; //Field offset: 0xA5
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40006C3")]
	public SRPLensFlareDistribution distribution; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x40006C4")]
	public float lengthSpread; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40006C5")]
	public AnimationCurve positionCurve; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40006C6")]
	public AnimationCurve scaleCurve; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40006C7")]
	public int seed; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40006C8")]
	public Gradient colorGradient; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[FormerlySerializedAs("intensityVariation")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x40006C9")]
	private float m_IntensityVariation; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD4")]
	[Token(Token = "0x40006CA")]
	public Vector2 positionVariation; //Field offset: 0xD4
	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x40006CB")]
	public float scaleVariation; //Field offset: 0xDC
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40006CC")]
	public float rotationVariation; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x40006CD")]
	public bool enableRadialDistortion; //Field offset: 0xE4
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40006CE")]
	public Vector2 targetSizeDistortion; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40006CF")]
	public AnimationCurve distortionCurve; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40006D0")]
	public bool distortionRelativeToCenter; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[FormerlySerializedAs("fallOff")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x40006D1")]
	private float m_FallOff; //Field offset: 0xFC
	[FieldOffset(Offset = "0x100")]
	[FormerlySerializedAs("edgeOffset")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x40006D2")]
	private float m_EdgeOffset; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[FormerlySerializedAs("sideCount")]
	[Min(3)]
	[SerializeField]
	[Token(Token = "0x40006D3")]
	private int m_SideCount; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[FormerlySerializedAs("sdfRoundness")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x40006D4")]
	private float m_SdfRoundness; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x40006D5")]
	public bool inverseSDF; //Field offset: 0x10C
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40006D6")]
	public float uniformAngle; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40006D7")]
	public AnimationCurve uniformAngleCurve; //Field offset: 0x118

	[Token(Token = "0x17000147")]
	public int count
	{
		[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
		[Token(Token = "0x6000B39")]
		 get { } //Length: 4
		[Address(RVA = "0x2C2F7C0", Offset = "0x2C2EBC0", Length = "0x10")]
		[Token(Token = "0x6000B3A")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700014A")]
	public float edgeOffset
	{
		[Address(RVA = "0x2C2F780", Offset = "0x2C2EB80", Length = "0x9")]
		[Token(Token = "0x6000B3F")]
		 get { } //Length: 9
		[Address(RVA = "0x2C2F7D0", Offset = "0x2C2EBD0", Length = "0x27")]
		[Token(Token = "0x6000B40")]
		 set { } //Length: 39
	}

	[Token(Token = "0x17000149")]
	public float fallOff
	{
		[Address(RVA = "0x2C2F790", Offset = "0x2C2EB90", Length = "0x9")]
		[Token(Token = "0x6000B3D")]
		 get { } //Length: 9
		[Address(RVA = "0x2C2F800", Offset = "0x2C2EC00", Length = "0x27")]
		[Token(Token = "0x6000B3E")]
		 set { } //Length: 39
	}

	[Token(Token = "0x17000148")]
	public float intensityVariation
	{
		[Address(RVA = "0xE26BE0", Offset = "0xE25FE0", Length = "0x9")]
		[Token(Token = "0x6000B3B")]
		 get { } //Length: 9
		[Address(RVA = "0x2C2F830", Offset = "0x2C2EC30", Length = "0x12")]
		[Token(Token = "0x6000B3C")]
		 set { } //Length: 18
	}

	[Token(Token = "0x17000146")]
	public float localIntensity
	{
		[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
		[Token(Token = "0x6000B37")]
		 get { } //Length: 6
		[Address(RVA = "0x2C2F850", Offset = "0x2C2EC50", Length = "0xF")]
		[Token(Token = "0x6000B38")]
		 set { } //Length: 15
	}

	[Token(Token = "0x1700014C")]
	public float sdfRoundness
	{
		[Address(RVA = "0x2C2F7A0", Offset = "0x2C2EBA0", Length = "0x9")]
		[Token(Token = "0x6000B43")]
		 get { } //Length: 9
		[Address(RVA = "0x2C2F860", Offset = "0x2C2EC60", Length = "0x27")]
		[Token(Token = "0x6000B44")]
		 set { } //Length: 39
	}

	[Token(Token = "0x1700014B")]
	public int sideCount
	{
		[Address(RVA = "0x2C2F7B0", Offset = "0x2C2EBB0", Length = "0x7")]
		[Token(Token = "0x6000B41")]
		 get { } //Length: 7
		[Address(RVA = "0x2C2F890", Offset = "0x2C2EC90", Length = "0x13")]
		[Token(Token = "0x6000B42")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x2C2EDD0", Offset = "0x2C2E1D0", Length = "0x9A3")]
	[Token(Token = "0x6000B35")]
	public LensFlareDataElementSRP() { }

	[Address(RVA = "0x2C2E700", Offset = "0x2C2DB00", Length = "0x6C7")]
	[Token(Token = "0x6000B36")]
	public LensFlareDataElementSRP Clone() { }

	[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
	[Token(Token = "0x6000B39")]
	public int get_count() { }

	[Address(RVA = "0x2C2F780", Offset = "0x2C2EB80", Length = "0x9")]
	[Token(Token = "0x6000B3F")]
	public float get_edgeOffset() { }

	[Address(RVA = "0x2C2F790", Offset = "0x2C2EB90", Length = "0x9")]
	[Token(Token = "0x6000B3D")]
	public float get_fallOff() { }

	[Address(RVA = "0xE26BE0", Offset = "0xE25FE0", Length = "0x9")]
	[Token(Token = "0x6000B3B")]
	public float get_intensityVariation() { }

	[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
	[Token(Token = "0x6000B37")]
	public float get_localIntensity() { }

	[Address(RVA = "0x2C2F7A0", Offset = "0x2C2EBA0", Length = "0x9")]
	[Token(Token = "0x6000B43")]
	public float get_sdfRoundness() { }

	[Address(RVA = "0x2C2F7B0", Offset = "0x2C2EBB0", Length = "0x7")]
	[Token(Token = "0x6000B41")]
	public int get_sideCount() { }

	[Address(RVA = "0x2C2F7C0", Offset = "0x2C2EBC0", Length = "0x10")]
	[Token(Token = "0x6000B3A")]
	public void set_count(int value) { }

	[Address(RVA = "0x2C2F7D0", Offset = "0x2C2EBD0", Length = "0x27")]
	[Token(Token = "0x6000B40")]
	public void set_edgeOffset(float value) { }

	[Address(RVA = "0x2C2F800", Offset = "0x2C2EC00", Length = "0x27")]
	[Token(Token = "0x6000B3E")]
	public void set_fallOff(float value) { }

	[Address(RVA = "0x2C2F830", Offset = "0x2C2EC30", Length = "0x12")]
	[Token(Token = "0x6000B3C")]
	public void set_intensityVariation(float value) { }

	[Address(RVA = "0x2C2F850", Offset = "0x2C2EC50", Length = "0xF")]
	[Token(Token = "0x6000B38")]
	public void set_localIntensity(float value) { }

	[Address(RVA = "0x2C2F860", Offset = "0x2C2EC60", Length = "0x27")]
	[Token(Token = "0x6000B44")]
	public void set_sdfRoundness(float value) { }

	[Address(RVA = "0x2C2F890", Offset = "0x2C2EC90", Length = "0x13")]
	[Token(Token = "0x6000B42")]
	public void set_sideCount(int value) { }

}

