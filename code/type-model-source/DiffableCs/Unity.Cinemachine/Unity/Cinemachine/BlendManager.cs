namespace Unity.Cinemachine;

[Token(Token = "0x2000076")]
internal class BlendManager : CameraBlendStack
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001F6")]
	private CinemachineBlend m_CurrentLiveCameras; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001F7")]
	private HashSet<ICinemachineCamera> m_PreviousLiveCameras; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001F8")]
	private ICinemachineCamera m_PreviousActiveCamera; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001F9")]
	private bool m_WasBlending; //Field offset: 0x40

	[Token(Token = "0x17000075")]
	public CinemachineBlend ActiveBlend
	{
		[Address(RVA = "0x2819EC0", Offset = "0x28192C0", Length = "0x3E")]
		[Token(Token = "0x600024D")]
		 get { } //Length: 62
		[Address(RVA = "0x281A1E0", Offset = "0x28195E0", Length = "0x8")]
		[Token(Token = "0x600024E")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000074")]
	public ICinemachineCamera ActiveVirtualCamera
	{
		[Address(RVA = "0x2819F00", Offset = "0x2819300", Length = "0xB")]
		[Token(Token = "0x600024B")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000078")]
	public CameraState CameraState
	{
		[Address(RVA = "0x2819F10", Offset = "0x2819310", Length = "0x9A")]
		[Token(Token = "0x6000253")]
		 get { } //Length: 154
	}

	[Token(Token = "0x17000077")]
	public string Description
	{
		[Address(RVA = "0x2819FB0", Offset = "0x28193B0", Length = "0x1D2")]
		[Token(Token = "0x6000250")]
		 get { } //Length: 466
	}

	[Token(Token = "0x17000076")]
	public bool IsBlending
	{
		[Address(RVA = "0x281A190", Offset = "0x2819590", Length = "0x4A")]
		[Token(Token = "0x600024F")]
		 get { } //Length: 74
	}

	[Address(RVA = "0x2819D90", Offset = "0x2819190", Length = "0x123")]
	[Token(Token = "0x6000257")]
	public BlendManager() { }

	[Address(RVA = "0x2819C70", Offset = "0x2819070", Length = "0x11C")]
	[CompilerGenerated]
	[Token(Token = "0x6000258")]
	internal static void <ProcessActiveCamera>g__CollectLiveCameras|21_0(CinemachineBlend blend, ref HashSet<ICinemachineCamera>& cams) { }

	[Address(RVA = "0x2819160", Offset = "0x2818560", Length = "0xF")]
	[Token(Token = "0x6000254")]
	public void ComputeCurrentBlend() { }

	[Address(RVA = "0x2819170", Offset = "0x2818570", Length = "0xC2")]
	[Token(Token = "0x600024C")]
	private static ICinemachineCamera DeepCamBFromBlend(CinemachineBlend blend) { }

	[Address(RVA = "0x2819EC0", Offset = "0x28192C0", Length = "0x3E")]
	[Token(Token = "0x600024D")]
	public CinemachineBlend get_ActiveBlend() { }

	[Address(RVA = "0x2819F00", Offset = "0x2819300", Length = "0xB")]
	[Token(Token = "0x600024B")]
	public ICinemachineCamera get_ActiveVirtualCamera() { }

	[Address(RVA = "0x2819F10", Offset = "0x2819310", Length = "0x9A")]
	[Token(Token = "0x6000253")]
	public CameraState get_CameraState() { }

	[Address(RVA = "0x2819FB0", Offset = "0x28193B0", Length = "0x1D2")]
	[Token(Token = "0x6000250")]
	public string get_Description() { }

	[Address(RVA = "0x281A190", Offset = "0x2819590", Length = "0x4A")]
	[Token(Token = "0x600024F")]
	public bool get_IsBlending() { }

	[Address(RVA = "0x28192F0", Offset = "0x28186F0", Length = "0x1E")]
	[Token(Token = "0x6000252")]
	public bool IsLive(ICinemachineCamera cam) { }

	[Address(RVA = "0x2819240", Offset = "0x2818640", Length = "0xAC")]
	[Token(Token = "0x6000251")]
	public bool IsLiveInBlend(ICinemachineCamera cam) { }

	[Address(RVA = "0x2819310", Offset = "0x2818710", Length = "0x15A")]
	[Token(Token = "0x600024A")]
	public virtual void OnEnable() { }

	[Address(RVA = "0x2819470", Offset = "0x2818870", Length = "0x7B0")]
	[Token(Token = "0x6000256")]
	public ICinemachineCamera ProcessActiveCamera(ICinemachineMixer mixer, Vector3 up, float deltaTime) { }

	[Address(RVA = "0x2819C30", Offset = "0x2819030", Length = "0x35")]
	[Token(Token = "0x6000255")]
	public void RefreshCurrentCameraState(Vector3 up, float deltaTime) { }

	[Address(RVA = "0x281A1E0", Offset = "0x28195E0", Length = "0x8")]
	[Token(Token = "0x600024E")]
	public void set_ActiveBlend(CinemachineBlend value) { }

}

