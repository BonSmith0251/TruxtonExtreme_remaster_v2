namespace UnityEngine.Rendering;

[AddComponentMenu("Rendering/Probe Adjustment Volume")]
[ExecuteAlways]
[Token(Token = "0x20000EF")]
public class ProbeAdjustmentVolume : MonoBehaviour, ISerializationCallbackReceiver
{
	[Token(Token = "0x20000F1")]
	internal enum Mode : int
	{
		InvalidateProbes = 0,
		OverrideValidityThreshold = 1,
		ApplyVirtualOffset = 2,
		OverrideVirtualOffsetSettings = 3,
		OverrideSkyDirection = 4,
		OverrideSampleCount = 5,
		OverrideRenderingLayerMask = 6,
		IntensityScale = 99,
	}

	[Token(Token = "0x20000F2")]
	internal enum RenderingLayerMaskOperation : int
	{
		Override = 0,
		Add = 1,
		Remove = 2,
	}

	[Token(Token = "0x20000F0")]
	internal enum Shape : int
	{
		Box = 0,
		Sphere = 1,
	}

	[Token(Token = "0x20000F3")]
	private enum Version : int
	{
		Initial = 0,
		Mode = 1,
		Count = 2,
	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000303")]
	[Tooltip("Select the shape used for this Probe Adjustment Volume.")]
	public Shape shape; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Min(0)]
	[Token(Token = "0x4000304")]
	[Tooltip("Modify the size of this Probe Adjustment Volume. This is unaffected by the GameObject's Transform's Scale property.")]
	public Vector3 size; //Field offset: 0x24
	[FieldOffset(Offset = "0x30")]
	[Min(0)]
	[Token(Token = "0x4000305")]
	[Tooltip("Modify the radius of this Probe Adjustment Volume. This is unaffected by the GameObject's Transform's Scale property.")]
	public float radius; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000306")]
	public Mode mode; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Range(0.0001, 2)]
	[Token(Token = "0x4000307")]
	[Tooltip("A multiplier applied to the intensity of probes covered by this Probe Adjustment Volume.")]
	public float intensityScale; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Range(0, 0.95)]
	[Token(Token = "0x4000308")]
	public float overriddenDilationThreshold; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000309")]
	public Vector3 virtualOffsetRotation; //Field offset: 0x40
	[FieldOffset(Offset = "0x4C")]
	[Min(0)]
	[Token(Token = "0x400030A")]
	public float virtualOffsetDistance; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Range(0, 1)]
	[Token(Token = "0x400030B")]
	[Tooltip("Determines how far Unity pushes a probe out of geometry after a ray hit.")]
	public float geometryBias; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Range(0, 0.95)]
	[Token(Token = "0x400030C")]
	public float virtualOffsetThreshold; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Range(-0.05, 0)]
	[Token(Token = "0x400030D")]
	[Tooltip("Distance from the probe position used to determine the origin of the sampling ray.")]
	public float rayOriginBias; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400030E")]
	[Tooltip("The direction for sampling the ambient probe in worldspace when using the Sky Visibility feature.")]
	public Vector3 skyDirection; //Field offset: 0x5C
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400030F")]
	internal Vector3 skyShadingDirectionRotation; //Field offset: 0x68
	[FieldOffset(Offset = "0x74")]
	[Logarithmic(1, 1024)]
	[Token(Token = "0x4000310")]
	[Tooltip("Number of samples for direct lighting computations.")]
	public int directSampleCount; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Logarithmic(1, 8192)]
	[Token(Token = "0x4000311")]
	[Tooltip("Number of samples for indirect lighting computations. This includes environment samples.")]
	public int indirectSampleCount; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Min(0)]
	[Token(Token = "0x4000312")]
	[Tooltip("Multiplier for the number of samples specified above.")]
	public int sampleCountMultiplier; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Min(0)]
	[Token(Token = "0x4000313")]
	[Tooltip("Maximum number of bounces for indirect lighting.")]
	public int maxBounces; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Logarithmic(1, 8192)]
	[Token(Token = "0x4000314")]
	public int skyOcclusionSampleCount; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Range(0, 5)]
	[Token(Token = "0x4000315")]
	public int skyOcclusionMaxBounces; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000316")]
	public RenderingLayerMaskOperation renderingLayerMaskOperation; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000317")]
	public byte renderingLayerMask; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[SerializeField]
	[Token(Token = "0x4000318")]
	private Version version; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Obsolete("This field is only kept for migration purpose. Use mode instead. #from(2023.1)")]
	[Token(Token = "0x4000319")]
	public bool invalidateProbes; //Field offset: 0x98
	[FieldOffset(Offset = "0x99")]
	[Obsolete("This field is only kept for migration purpose. Use mode instead. #from(2023.1)")]
	[Token(Token = "0x400031A")]
	public bool overrideDilationThreshold; //Field offset: 0x99

	[Address(RVA = "0x2C0E0B0", Offset = "0x2C0D4B0", Length = "0x149")]
	[Token(Token = "0x6000868")]
	public ProbeAdjustmentVolume() { }

	[Address(RVA = "0x2C0E040", Offset = "0x2C0D440", Length = "0x4A")]
	[Token(Token = "0x6000867")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[Address(RVA = "0x2C0E090", Offset = "0x2C0D490", Length = "0x14")]
	[Token(Token = "0x6000866")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

