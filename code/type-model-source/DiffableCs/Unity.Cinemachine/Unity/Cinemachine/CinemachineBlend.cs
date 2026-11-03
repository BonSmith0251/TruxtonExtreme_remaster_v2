namespace Unity.Cinemachine;

[Token(Token = "0x2000084")]
public class CinemachineBlend
{
	[Token(Token = "0x2000085")]
	internal interface IBlender
	{

		[Token(Token = "0x60002A7")]
		public CameraState GetIntermediateState(ICinemachineCamera CamA, ICinemachineCamera CamB, float t) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400023D")]
	public ICinemachineCamera CamA; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400023E")]
	public ICinemachineCamera CamB; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400023F")]
	public AnimationCurve BlendCurve; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000240")]
	public float TimeInBlend; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000241")]
	private IBlender <CustomBlender>k__BackingField; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000242")]
	public float Duration; //Field offset: 0x38

	[Token(Token = "0x17000086")]
	public float BlendWeight
	{
		[Address(RVA = "0x283B270", Offset = "0x283A670", Length = "0x8E")]
		[Token(Token = "0x600029B")]
		 get { } //Length: 142
	}

	[Token(Token = "0x17000087")]
	public IBlender CustomBlender
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600029C")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600029D")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700008A")]
	public string Description
	{
		[Address(RVA = "0x283B300", Offset = "0x283A700", Length = "0x188")]
		[Token(Token = "0x60002A0")]
		 get { } //Length: 392
	}

	[Token(Token = "0x17000089")]
	public bool IsComplete
	{
		[Address(RVA = "0x283B490", Offset = "0x283A890", Length = "0x24")]
		[Token(Token = "0x600029F")]
		 get { } //Length: 36
	}

	[Token(Token = "0x17000088")]
	public bool IsValid
	{
		[Address(RVA = "0x283B4C0", Offset = "0x283A8C0", Length = "0x76")]
		[Token(Token = "0x600029E")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700008B")]
	public CameraState State
	{
		[Address(RVA = "0x283B540", Offset = "0x283A940", Length = "0x582")]
		[Token(Token = "0x60002A5")]
		 get { } //Length: 1410
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60002A6")]
	public CinemachineBlend() { }

	[Address(RVA = "0x283AF90", Offset = "0x283A390", Length = "0x4C")]
	[Token(Token = "0x60002A3")]
	public void ClearBlend() { }

	[Address(RVA = "0x283AFE0", Offset = "0x283A3E0", Length = "0x74")]
	[Token(Token = "0x60002A2")]
	public void CopyFrom(CinemachineBlend src) { }

	[Address(RVA = "0x283B270", Offset = "0x283A670", Length = "0x8E")]
	[Token(Token = "0x600029B")]
	public float get_BlendWeight() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600029C")]
	public IBlender get_CustomBlender() { }

	[Address(RVA = "0x283B300", Offset = "0x283A700", Length = "0x188")]
	[Token(Token = "0x60002A0")]
	public string get_Description() { }

	[Address(RVA = "0x283B490", Offset = "0x283A890", Length = "0x24")]
	[Token(Token = "0x600029F")]
	public bool get_IsComplete() { }

	[Address(RVA = "0x283B4C0", Offset = "0x283A8C0", Length = "0x76")]
	[Token(Token = "0x600029E")]
	public bool get_IsValid() { }

	[Address(RVA = "0x283B540", Offset = "0x283A940", Length = "0x582")]
	[Token(Token = "0x60002A5")]
	public CameraState get_State() { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600029D")]
	public void set_CustomBlender(IBlender value) { }

	[Address(RVA = "0x283B060", Offset = "0x283A460", Length = "0xF9")]
	[Token(Token = "0x60002A4")]
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x283B160", Offset = "0x283A560", Length = "0x106")]
	[Token(Token = "0x60002A1")]
	public bool Uses(ICinemachineCamera cam) { }

}

