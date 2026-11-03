namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Cinemachine Mixing Camera")]
[DisallowMultipleComponent]
[ExcludeFromPreset]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineMixingCamera.html")]
[Token(Token = "0x200003C")]
public class CinemachineMixingCamera : CinemachineCameraManagerBase
{
	[Token(Token = "0x40000DB")]
	public const int MaxCameras = 8; //Field offset: 0x0
	[FieldOffset(Offset = "0x208")]
	[FormerlySerializedAs("m_Weight0")]
	[Token(Token = "0x40000DC")]
	[Tooltip("The weight of the first tracked camera")]
	public float Weight0; //Field offset: 0x208
	[FieldOffset(Offset = "0x20C")]
	[FormerlySerializedAs("m_Weight1")]
	[Token(Token = "0x40000DD")]
	[Tooltip("The weight of the second tracked camera")]
	public float Weight1; //Field offset: 0x20C
	[FieldOffset(Offset = "0x210")]
	[FormerlySerializedAs("m_Weight2")]
	[Token(Token = "0x40000DE")]
	[Tooltip("The weight of the third tracked camera")]
	public float Weight2; //Field offset: 0x210
	[FieldOffset(Offset = "0x214")]
	[FormerlySerializedAs("m_Weight3")]
	[Token(Token = "0x40000DF")]
	[Tooltip("The weight of the fourth tracked camera")]
	public float Weight3; //Field offset: 0x214
	[FieldOffset(Offset = "0x218")]
	[FormerlySerializedAs("m_Weight4")]
	[Token(Token = "0x40000E0")]
	[Tooltip("The weight of the fifth tracked camera")]
	public float Weight4; //Field offset: 0x218
	[FieldOffset(Offset = "0x21C")]
	[FormerlySerializedAs("m_Weight5")]
	[Token(Token = "0x40000E1")]
	[Tooltip("The weight of the sixth tracked camera")]
	public float Weight5; //Field offset: 0x21C
	[FieldOffset(Offset = "0x220")]
	[FormerlySerializedAs("m_Weight6")]
	[Token(Token = "0x40000E2")]
	[Tooltip("The weight of the seventh tracked camera")]
	public float Weight6; //Field offset: 0x220
	[FieldOffset(Offset = "0x224")]
	[FormerlySerializedAs("m_Weight7")]
	[Token(Token = "0x40000E3")]
	[Tooltip("The weight of the eighth tracked camera")]
	public float Weight7; //Field offset: 0x224
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x40000E4")]
	private CameraState m_CameraState; //Field offset: 0x228
	[FieldOffset(Offset = "0x338")]
	[Token(Token = "0x40000E5")]
	private Dictionary<CinemachineVirtualCameraBase, Int32> m_IndexMap; //Field offset: 0x338
	[FieldOffset(Offset = "0x340")]
	[Token(Token = "0x40000E6")]
	private float m_LiveChildPercent; //Field offset: 0x340

	[Token(Token = "0x17000024")]
	public virtual string Description
	{
		[Address(RVA = "0x2813AA0", Offset = "0x2812EA0", Length = "0x207")]
		[Token(Token = "0x6000100")]
		 get { } //Length: 519
	}

	[Token(Token = "0x17000023")]
	public virtual CameraState State
	{
		[Address(RVA = "0x2813CB0", Offset = "0x28130B0", Length = "0x76")]
		[Token(Token = "0x60000FF")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x2813900", Offset = "0x2812D00", Length = "0x197")]
	[Token(Token = "0x600010A")]
	public CinemachineMixingCamera() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000109")]
	protected virtual CinemachineVirtualCameraBase ChooseCurrentCamera(Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x2813AA0", Offset = "0x2812EA0", Length = "0x207")]
	[Token(Token = "0x6000100")]
	public virtual string get_Description() { }

	[Address(RVA = "0x2813CB0", Offset = "0x28130B0", Length = "0x76")]
	[Token(Token = "0x60000FF")]
	public virtual CameraState get_State() { }

	[Address(RVA = "0x2812A90", Offset = "0x2811E90", Length = "0x110")]
	[Token(Token = "0x6000101")]
	public float GetWeight(int index) { }

	[Address(RVA = "0x28128B0", Offset = "0x2811CB0", Length = "0x1B4")]
	[Token(Token = "0x6000103")]
	public float GetWeight(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x2812BC0", Offset = "0x2811FC0", Length = "0x4F7")]
	[Token(Token = "0x6000108")]
	public virtual void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x28130C0", Offset = "0x28124C0", Length = "0x101")]
	[Token(Token = "0x6000105")]
	public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false) { }

	[Address(RVA = "0x28131D0", Offset = "0x28125D0", Length = "0x124")]
	[Token(Token = "0x6000107")]
	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x2813300", Offset = "0x2812700", Length = "0x5C")]
	[Token(Token = "0x60000FD")]
	private void OnValidate() { }

	[Address(RVA = "0x2813360", Offset = "0x2812760", Length = "0x57")]
	[Token(Token = "0x60000FE")]
	protected virtual void Reset() { }

	[Address(RVA = "0x28133C0", Offset = "0x28127C0", Length = "0x144")]
	[Token(Token = "0x6000102")]
	public void SetWeight(int index, float w) { }

	[Address(RVA = "0x2813530", Offset = "0x2812930", Length = "0x26C")]
	[Token(Token = "0x6000104")]
	public void SetWeight(CinemachineVirtualCameraBase vcam, float w) { }

	[Address(RVA = "0x28137C0", Offset = "0x2812BC0", Length = "0x132")]
	[Token(Token = "0x6000106")]
	protected virtual bool UpdateCameraCache() { }

}

