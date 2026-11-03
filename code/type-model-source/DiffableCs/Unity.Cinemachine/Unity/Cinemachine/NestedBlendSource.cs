namespace Unity.Cinemachine;

[Token(Token = "0x2000089")]
public class NestedBlendSource : ICinemachineCamera
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000250")]
	private string m_Name; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000251")]
	private CinemachineBlend <Blend>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000252")]
	private CameraState <State>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700008E")]
	public internal CinemachineBlend Blend
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60002B1")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60002B2")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000090")]
	public override string Description
	{
		[Address(RVA = "0x2846F70", Offset = "0x2846370", Length = "0x1C4")]
		[Token(Token = "0x60002B4")]
		 get { } //Length: 452
	}

	[Token(Token = "0x17000092")]
	public override bool IsValid
	{
		[Address(RVA = "0x2847140", Offset = "0x2846540", Length = "0x15")]
		[Token(Token = "0x60002B7")]
		 get { } //Length: 21
	}

	[Token(Token = "0x1700008F")]
	public override string Name
	{
		[Address(RVA = "0x2847160", Offset = "0x2846560", Length = "0x9D")]
		[Token(Token = "0x60002B3")]
		 get { } //Length: 157
	}

	[Token(Token = "0x17000093")]
	public override ICinemachineMixer ParentCamera
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60002B8")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000091")]
	public private override CameraState State
	{
		[Address(RVA = "0x2847200", Offset = "0x2846600", Length = "0x76")]
		[CompilerGenerated]
		[Token(Token = "0x60002B5")]
		 get { } //Length: 118
		[Address(RVA = "0x2847280", Offset = "0x2846680", Length = "0x77")]
		[CompilerGenerated]
		[Token(Token = "0x60002B6")]
		private set { } //Length: 119
	}

	[Address(RVA = "0x1F079E0", Offset = "0x1F06DE0", Length = "0x31")]
	[Token(Token = "0x60002B0")]
	public NestedBlendSource(CinemachineBlend blend) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60002B1")]
	public CinemachineBlend get_Blend() { }

	[Address(RVA = "0x2846F70", Offset = "0x2846370", Length = "0x1C4")]
	[Token(Token = "0x60002B4")]
	public override string get_Description() { }

	[Address(RVA = "0x2847140", Offset = "0x2846540", Length = "0x15")]
	[Token(Token = "0x60002B7")]
	public override bool get_IsValid() { }

	[Address(RVA = "0x2847160", Offset = "0x2846560", Length = "0x9D")]
	[Token(Token = "0x60002B3")]
	public override string get_Name() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60002B8")]
	public override ICinemachineMixer get_ParentCamera() { }

	[Address(RVA = "0x2847200", Offset = "0x2846600", Length = "0x76")]
	[CompilerGenerated]
	[Token(Token = "0x60002B5")]
	public override CameraState get_State() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002BA")]
	public override void OnCameraActivated(ActivationEventParams evt) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60002B2")]
	internal void set_Blend(CinemachineBlend value) { }

	[Address(RVA = "0x2847280", Offset = "0x2846680", Length = "0x77")]
	[CompilerGenerated]
	[Token(Token = "0x60002B6")]
	private void set_State(CameraState value) { }

	[Address(RVA = "0x2846D50", Offset = "0x2846150", Length = "0x21D")]
	[Token(Token = "0x60002B9")]
	public override void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

}

