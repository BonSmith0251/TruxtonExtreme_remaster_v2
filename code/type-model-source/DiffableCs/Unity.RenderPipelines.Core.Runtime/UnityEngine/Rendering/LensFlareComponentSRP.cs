namespace UnityEngine.Rendering;

[AddComponentMenu("Rendering/Lens Flare (SRP)")]
[ExecuteAlways]
[Token(Token = "0x2000154")]
public sealed class LensFlareComponentSRP : MonoBehaviour
{
	[Token(Token = "0x2000155")]
	private enum Version : int
	{
		Initial = 0,
	}

	[Token(Token = "0x400068E")]
	private static float sCelestialAngularRadius; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400067B")]
	private LensFlareDataSRP m_LensFlareData; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400067C")]
	private Version version; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Min(0)]
	[Token(Token = "0x400067D")]
	public float intensity; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Min(1E-05)]
	[Token(Token = "0x400067E")]
	public float maxAttenuationDistance; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Min(1E-05)]
	[Token(Token = "0x400067F")]
	public float maxAttenuationScale; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000680")]
	public AnimationCurve distanceAttenuationCurve; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000681")]
	public AnimationCurve scaleByDistanceCurve; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000682")]
	public bool attenuationByLightShape; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000683")]
	public AnimationCurve radialScreenAttenuationCurve; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000684")]
	public bool useOcclusion; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[Obsolete("Replaced by environmentOcclusion. #from(6000.0)")]
	[Token(Token = "0x4000685")]
	public bool useBackgroundCloudOcclusion; //Field offset: 0x59
	[FieldOffset(Offset = "0x5A")]
	[FormerlySerializedAs("volumetricCloudOcclusion")]
	[FormerlySerializedAs("useFogOpacityOcclusion")]
	[Token(Token = "0x4000686")]
	public bool environmentOcclusion; //Field offset: 0x5A
	[FieldOffset(Offset = "0x5B")]
	[Obsolete("Replaced by environmentOcclusion. #from(6000.0)")]
	[Token(Token = "0x4000687")]
	public bool useWaterOcclusion; //Field offset: 0x5B
	[FieldOffset(Offset = "0x5C")]
	[Min(0)]
	[Token(Token = "0x4000688")]
	public float occlusionRadius; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Range(1, 64)]
	[Token(Token = "0x4000689")]
	public uint sampleCount; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400068A")]
	public float occlusionOffset; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Min(0)]
	[Token(Token = "0x400068B")]
	public float scale; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400068C")]
	public bool allowOffScreen; //Field offset: 0x6C
	[FieldOffset(Offset = "0x6D")]
	[Obsolete("Please use environmentOcclusion instead. #from(6000.0)")]
	[Token(Token = "0x400068D")]
	public bool volumetricCloudOcclusion; //Field offset: 0x6D
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400068F")]
	public TextureCurve occlusionRemapCurve; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000690")]
	public Light lightOverride; //Field offset: 0x78

	[Token(Token = "0x17000145")]
	public LensFlareDataSRP lensFlareData
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000B2B")]
		 get { } //Length: 5
		[Address(RVA = "0x2C2E610", Offset = "0x2C2DA10", Length = "0xED")]
		[Token(Token = "0x6000B2C")]
		 set { } //Length: 237
	}

	[Address(RVA = "0x2C2E140", Offset = "0x2C2D540", Length = "0x39")]
	[Token(Token = "0x6000B34")]
	private static LensFlareComponentSRP() { }

	[Address(RVA = "0x2C2E180", Offset = "0x2C2D580", Length = "0x3B4")]
	[Token(Token = "0x6000B33")]
	public LensFlareComponentSRP() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B2E")]
	private void Awake() { }

	[Address(RVA = "0x2C2E540", Offset = "0x2C2D940", Length = "0xC8")]
	[Token(Token = "0x6000B2D")]
	public float celestialProjectedOcclusionRadius(Camera mainCam) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000B2B")]
	public LensFlareDataSRP get_lensFlareData() { }

	[Address(RVA = "0x2C2DF00", Offset = "0x2C2D300", Length = "0x1D")]
	[Token(Token = "0x6000B32")]
	private void OnDestroy() { }

	[Address(RVA = "0x2C2DF20", Offset = "0x2C2D320", Length = "0x5E")]
	[Token(Token = "0x6000B30")]
	private void OnDisable() { }

	[Address(RVA = "0x2C2DF80", Offset = "0x2C2D380", Length = "0xCC")]
	[Token(Token = "0x6000B2F")]
	private void OnEnable() { }

	[Address(RVA = "0x2C2E050", Offset = "0x2C2D450", Length = "0xE0")]
	[Token(Token = "0x6000B31")]
	private void OnValidate() { }

	[Address(RVA = "0x2C2E610", Offset = "0x2C2DA10", Length = "0xED")]
	[Token(Token = "0x6000B2C")]
	public void set_lensFlareData(LensFlareDataSRP value) { }

}

