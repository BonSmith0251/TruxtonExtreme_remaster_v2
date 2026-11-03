namespace InGame.Kernel;

[DefaultExecutionOrder(1)]
[Token(Token = "0x20000A5")]
public class PositionShiftMan : MonoBehaviourSingleton<PositionShiftMan>
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004F4")]
	private Camera _mainCam; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004F5")]
	private Transform _gameTrans; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40004F6")]
	private Transform _camTrans; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40004F7")]
	private Vector3 _camLPos; //Field offset: 0x38
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40004F8")]
	private bool _nullError; //Field offset: 0x44

	[Token(Token = "0x17000127")]
	private Transform CamTrans
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000606")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000126")]
	public Transform GameTrans
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000605")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1D3E010", Offset = "0x1D3D410", Length = "0x39")]
	[Token(Token = "0x600060A")]
	public PositionShiftMan() { }

	[Address(RVA = "0x1D3DC00", Offset = "0x1D3D000", Length = "0x1B1")]
	[Token(Token = "0x6000608")]
	private float CalcHorizon(in Vector3 lpos) { }

	[Address(RVA = "0x1D3DDC0", Offset = "0x1D3D1C0", Length = "0x17D")]
	[Token(Token = "0x6000609")]
	public float CalcPositionScale(in Vector3 wpos, float baseY, float targetY, out Vector3 resWpos) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000606")]
	private Transform get_CamTrans() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000605")]
	public Transform get_GameTrans() { }

	[Address(RVA = "0x1D3DF40", Offset = "0x1D3D340", Length = "0xC3")]
	[Token(Token = "0x6000607")]
	public void UpdateGameParameter(Camera mainCamera, Transform gameRoot) { }

}

