namespace UnityEngine.VFX.Utility;

[Token(Token = "0x200000D")]
[VFXBinder("URP/URP Camera")]
public class URPCameraBinder : VFXBinderBase
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000030")]
	public UniversalAdditionalCameraData AdditionalData; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000031")]
	private Camera m_Camera; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000032")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"UnityEditor.VFX.CameraType"})]
	private ExposedProperty CameraProperty; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000033")]
	private ExposedProperty m_Position; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000034")]
	private ExposedProperty m_Angles; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000035")]
	private ExposedProperty m_Scale; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000036")]
	private ExposedProperty m_FieldOfView; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000037")]
	private ExposedProperty m_NearPlane; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000038")]
	private ExposedProperty m_FarPlane; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000039")]
	private ExposedProperty m_AspectRatio; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400003A")]
	private ExposedProperty m_Dimensions; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400003B")]
	private ExposedProperty m_ScaledDimensions; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400003C")]
	private ExposedProperty m_DepthBuffer; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400003D")]
	private ExposedProperty m_ColorBuffer; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400003E")]
	private ExposedProperty m_Orthographic; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400003F")]
	private ExposedProperty m_OrthographicSize; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000040")]
	private ExposedProperty m_LensShift; //Field offset: 0xA8

	[Address(RVA = "0x2D66180", Offset = "0x2D65580", Length = "0x52")]
	[Token(Token = "0x6000027")]
	public URPCameraBinder() { }

	[Address(RVA = "0x2D64E80", Offset = "0x2D64280", Length = "0x27A")]
	[Token(Token = "0x6000024")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2D65100", Offset = "0x2D64500", Length = "0xE0")]
	[Token(Token = "0x6000022")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x2D651F0", Offset = "0x2D645F0", Length = "0xF3")]
	[Token(Token = "0x6000021")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2D652F0", Offset = "0x2D646F0", Length = "0xE0")]
	[Token(Token = "0x6000023")]
	private void OnValidate() { }

	[Address(RVA = "0x2D653E0", Offset = "0x2D647E0", Length = "0x5F")]
	[Token(Token = "0x6000020")]
	private static void RequestHistoryAccess(IPerFrameHistoryAccessTracker access) { }

	[Address(RVA = "0x2D65440", Offset = "0x2D64840", Length = "0x35")]
	[Token(Token = "0x600001E")]
	public void SetCameraProperty(string name) { }

	[Address(RVA = "0x2D65480", Offset = "0x2D64880", Length = "0xE4")]
	[Token(Token = "0x6000026")]
	public virtual string ToString() { }

	[Address(RVA = "0x2D65570", Offset = "0x2D64970", Length = "0x7F4")]
	[Token(Token = "0x6000025")]
	public virtual void UpdateBinding(VisualEffect component) { }

	[Address(RVA = "0x2D65D70", Offset = "0x2D65170", Length = "0x407")]
	[Token(Token = "0x600001F")]
	private void UpdateSubProperties() { }

}

