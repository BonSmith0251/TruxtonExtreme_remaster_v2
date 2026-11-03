namespace Unity.Cinemachine;

[Token(Token = "0x200008C")]
public abstract class CinemachineCameraManagerBase : CinemachineVirtualCameraBase, ICinemachineMixer, ICinemachineCamera
{
	[Token(Token = "0x200008D")]
	internal struct DefaultTargetSettings
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000260")]
		[Tooltip("If enabled, a default target will be available.  It will be used if a child rig needs a target and doesn't specify one itself.")]
		public bool Enabled; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[NoSaveDuringPlay]
		[Token(Token = "0x4000261")]
		[Tooltip("Default target for the camera children, which may be used if the child rig does not specify a target of its own.")]
		public CameraTarget Target; //Field offset: 0x8

	}

	[FieldOffset(Offset = "0xA0")]
	[FoldoutWithEnabledButton("Enabled")]
	[Token(Token = "0x4000258")]
	public DefaultTargetSettings DefaultTarget; //Field offset: 0xA0
	[FieldOffset(Offset = "0xC0")]
	[FormerlySerializedAs("m_DefaultBlend")]
	[Token(Token = "0x4000259")]
	[Tooltip("The blend which is used if you don't explicitly define a blend between two Virtual Camera children")]
	public CinemachineBlendDefinition DefaultBlend; //Field offset: 0xC0
	[EmbeddedBlenderSettingsProperty]
	[FieldOffset(Offset = "0xD0")]
	[FormerlySerializedAs("m_CustomBlends")]
	[Token(Token = "0x400025A")]
	[Tooltip("This is the asset which contains custom settings for specific child blends")]
	public CinemachineBlenderSettings CustomBlends; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400025B")]
	private List<CinemachineVirtualCameraBase> m_ChildCameras; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400025C")]
	private int m_ChildCountCache; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400025D")]
	private readonly BlendManager m_BlendManager; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400025E")]
	private CameraState m_State; //Field offset: 0xF0
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x400025F")]
	private ICinemachineCamera m_TransitioningFrom; //Field offset: 0x200

	[Token(Token = "0x17000099")]
	public CinemachineBlend ActiveBlend
	{
		[Address(RVA = "0x283D490", Offset = "0x283C890", Length = "0x45")]
		[Token(Token = "0x60002C8")]
		 get { } //Length: 69
		[Address(RVA = "0x283D6A0", Offset = "0x283CAA0", Length = "0x21")]
		[Token(Token = "0x60002C9")]
		 set { } //Length: 33
	}

	[Token(Token = "0x17000096")]
	public List<CinemachineVirtualCameraBase> ChildCameras
	{
		[Address(RVA = "0x283D4E0", Offset = "0x283C8E0", Length = "0x29")]
		[Token(Token = "0x60002C4")]
		 get { } //Length: 41
	}

	[Token(Token = "0x17000094")]
	public virtual string Description
	{
		[Address(RVA = "0x283D510", Offset = "0x283C910", Length = "0x20")]
		[Token(Token = "0x60002C1")]
		 get { } //Length: 32
	}

	[Token(Token = "0x1700009C")]
	public virtual Transform Follow
	{
		[Address(RVA = "0x283D540", Offset = "0x283C940", Length = "0x1B")]
		[Token(Token = "0x60002CD")]
		 get { } //Length: 27
		[Address(RVA = "0x283D6D0", Offset = "0x283CAD0", Length = "0x16")]
		[Token(Token = "0x60002CE")]
		 set { } //Length: 22
	}

	[Token(Token = "0x17000098")]
	public bool IsBlending
	{
		[Address(RVA = "0x283D560", Offset = "0x283C960", Length = "0x20")]
		[Token(Token = "0x60002C7")]
		 get { } //Length: 32
	}

	[Token(Token = "0x1700009A")]
	public ICinemachineCamera LiveChild
	{
		[Address(RVA = "0x283D590", Offset = "0x283C990", Length = "0x45")]
		[Token(Token = "0x60002CA")]
		 get { } //Length: 69
	}

	[Token(Token = "0x1700009B")]
	public virtual Transform LookAt
	{
		[Address(RVA = "0x283D5E0", Offset = "0x283C9E0", Length = "0x33")]
		[Token(Token = "0x60002CB")]
		 get { } //Length: 51
		[Address(RVA = "0x283D6F0", Offset = "0x283CAF0", Length = "0x21")]
		[Token(Token = "0x60002CC")]
		 set { } //Length: 33
	}

	[Token(Token = "0x17000097")]
	public virtual bool PreviousStateIsValid
	{
		[Address(RVA = "0xD11AF0", Offset = "0xD10EF0", Length = "0x8")]
		[Token(Token = "0x60002C5")]
		 get { } //Length: 8
		[Address(RVA = "0x283D720", Offset = "0x283CB20", Length = "0xAC")]
		[Token(Token = "0x60002C6")]
		 set { } //Length: 172
	}

	[Token(Token = "0x17000095")]
	public virtual CameraState State
	{
		[Address(RVA = "0x283D620", Offset = "0x283CA20", Length = "0x76")]
		[Token(Token = "0x60002C2")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x283D2A0", Offset = "0x283C6A0", Length = "0x1E5")]
	[Token(Token = "0x60002DB")]
	protected CinemachineCameraManagerBase() { }

	[Token(Token = "0x60002D1")]
	protected abstract CinemachineVirtualCameraBase ChooseCurrentCamera(Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x283BF20", Offset = "0x283B320", Length = "0x164")]
	[Token(Token = "0x60002DA")]
	protected void FinalizeCameraState(float deltaTime) { }

	[Address(RVA = "0x283C090", Offset = "0x283B490", Length = "0x13B")]
	[Token(Token = "0x60002D3")]
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x283D490", Offset = "0x283C890", Length = "0x45")]
	[Token(Token = "0x60002C8")]
	public CinemachineBlend get_ActiveBlend() { }

	[Address(RVA = "0x283D4E0", Offset = "0x283C8E0", Length = "0x29")]
	[Token(Token = "0x60002C4")]
	public List<CinemachineVirtualCameraBase> get_ChildCameras() { }

	[Address(RVA = "0x283D510", Offset = "0x283C910", Length = "0x20")]
	[Token(Token = "0x60002C1")]
	public virtual string get_Description() { }

	[Address(RVA = "0x283D540", Offset = "0x283C940", Length = "0x1B")]
	[Token(Token = "0x60002CD")]
	public virtual Transform get_Follow() { }

	[Address(RVA = "0x283D560", Offset = "0x283C960", Length = "0x20")]
	[Token(Token = "0x60002C7")]
	public bool get_IsBlending() { }

	[Address(RVA = "0x283D590", Offset = "0x283C990", Length = "0x45")]
	[Token(Token = "0x60002CA")]
	public ICinemachineCamera get_LiveChild() { }

	[Address(RVA = "0x283D5E0", Offset = "0x283C9E0", Length = "0x33")]
	[Token(Token = "0x60002CB")]
	public virtual Transform get_LookAt() { }

	[Address(RVA = "0xD11AF0", Offset = "0xD10EF0", Length = "0x8")]
	[Token(Token = "0x60002C5")]
	public virtual bool get_PreviousStateIsValid() { }

	[Address(RVA = "0x283D620", Offset = "0x283CA20", Length = "0x76")]
	[Token(Token = "0x60002C2")]
	public virtual CameraState get_State() { }

	[Address(RVA = "0x283C1D0", Offset = "0x283B5D0", Length = "0x554")]
	[Token(Token = "0x60002CF")]
	public virtual void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x283C730", Offset = "0x283BB30", Length = "0x40")]
	[Token(Token = "0x60002D5")]
	public void InvalidateCameraCache() { }

	[Address(RVA = "0x283C770", Offset = "0x283BB70", Length = "0x21")]
	[Token(Token = "0x60002C3")]
	public override bool IsLiveChild(ICinemachineCamera cam, bool dominantChildOnly = false) { }

	[Address(RVA = "0x283C7A0", Offset = "0x283BBA0", Length = "0x1D9")]
	[Token(Token = "0x60002D0")]
	protected override CinemachineBlendDefinition LookupBlend(ICinemachineCamera outgoing, ICinemachineCamera incoming) { }

	[Address(RVA = "0x283C980", Offset = "0x283BD80", Length = "0xC3")]
	[Token(Token = "0x60002C0")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x283CA50", Offset = "0x283BE50", Length = "0x1C3")]
	[Token(Token = "0x60002BF")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x283CC20", Offset = "0x283C020", Length = "0x125")]
	[Token(Token = "0x60002D2")]
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x283C730", Offset = "0x283BB30", Length = "0x40")]
	[Token(Token = "0x60002D7")]
	protected override void OnTransformChildrenChanged() { }

	[Address(RVA = "0x283CD50", Offset = "0x283C150", Length = "0x1F0")]
	[Token(Token = "0x60002D4")]
	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x283CF80", Offset = "0x283C380", Length = "0x5A")]
	[Token(Token = "0x60002BE")]
	protected override void Reset() { }

	[Address(RVA = "0x283CF50", Offset = "0x283C350", Length = "0x20")]
	[Token(Token = "0x60002D9")]
	protected void ResetLiveChild() { }

	[Address(RVA = "0x283D6A0", Offset = "0x283CAA0", Length = "0x21")]
	[Token(Token = "0x60002C9")]
	public void set_ActiveBlend(CinemachineBlend value) { }

	[Address(RVA = "0x283D6D0", Offset = "0x283CAD0", Length = "0x16")]
	[Token(Token = "0x60002CE")]
	public virtual void set_Follow(Transform value) { }

	[Address(RVA = "0x283D6F0", Offset = "0x283CAF0", Length = "0x21")]
	[Token(Token = "0x60002CC")]
	public virtual void set_LookAt(Transform value) { }

	[Address(RVA = "0x283D720", Offset = "0x283CB20", Length = "0xAC")]
	[Token(Token = "0x60002C6")]
	public virtual void set_PreviousStateIsValid(bool value) { }

	[Address(RVA = "0x283CFE0", Offset = "0x283C3E0", Length = "0xB8")]
	[Token(Token = "0x60002D8")]
	protected void SetLiveChild(ICinemachineCamera activeCamera, Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x283D0A0", Offset = "0x283C4A0", Length = "0x1F2")]
	[Token(Token = "0x60002D6")]
	protected override bool UpdateCameraCache() { }

}

