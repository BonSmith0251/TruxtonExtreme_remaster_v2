namespace InGame.Kernel;

[Token(Token = "0x20000AF")]
public class SimpleMoveJewel : SimpleMove
{
	[Token(Token = "0x400053A")]
	private static readonly float HomingAngleF; //Field offset: 0x0
	[Token(Token = "0x400053B")]
	private const float _jewel_init_x_min = -50; //Field offset: 0x0
	[Token(Token = "0x400053C")]
	private const float _jewel_init_x_max = 50; //Field offset: 0x0
	[Token(Token = "0x400053D")]
	private const float _jewel_init_z_min = -10; //Field offset: 0x0
	[Token(Token = "0x400053E")]
	private const float _jewel_init_z_max = 25; //Field offset: 0x0
	[Token(Token = "0x400053F")]
	private const float _jewel_gravity_x = 10; //Field offset: 0x0
	[Token(Token = "0x4000540")]
	private const float _jewel_gravity_z = -75; //Field offset: 0x0
	[Token(Token = "0x4000541")]
	private const float _jewel_gravity_z_max = -400; //Field offset: 0x0
	[Token(Token = "0x4000542")]
	private const float _jewel_gravity_y = 20; //Field offset: 0x0
	[Token(Token = "0x4000543")]
	private const float _homing_speed_max = 500; //Field offset: 0x0
	[Token(Token = "0x4000544")]
	private const float _homing_acc_speed = 25; //Field offset: 0x0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000538")]
	private int _targetPlayer; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000539")]
	private Vector3 _jgrv; //Field offset: 0xEC

	[Token(Token = "0x17000137")]
	public bool IsTargeting
	{
		[Address(RVA = "0x1D417A0", Offset = "0x1D40BA0", Length = "0xB")]
		[Token(Token = "0x6000662")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000136")]
	public int TargetPlayer
	{
		[Address(RVA = "0xE26980", Offset = "0xE25D80", Length = "0x7")]
		[Token(Token = "0x6000661")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x1D41CD0", Offset = "0x1D410D0", Length = "0xC6")]
	[Token(Token = "0x6000660")]
	private void _updateGravity(float dt) { }

	[Address(RVA = "0x1D41C10", Offset = "0x1D41010", Length = "0x39")]
	[Token(Token = "0x6000664")]
	private static SimpleMoveJewel() { }

	[Address(RVA = "0x1D41C50", Offset = "0x1D41050", Length = "0x75")]
	[Token(Token = "0x6000663")]
	public SimpleMoveJewel() { }

	[Address(RVA = "0x1D41730", Offset = "0x1D40B30", Length = "0x6E")]
	[Token(Token = "0x600065C")]
	public void CancelHorming() { }

	[Address(RVA = "0x1D417A0", Offset = "0x1D40BA0", Length = "0xB")]
	[Token(Token = "0x6000662")]
	public bool get_IsTargeting() { }

	[Address(RVA = "0xE26980", Offset = "0xE25D80", Length = "0x7")]
	[Token(Token = "0x6000661")]
	public int get_TargetPlayer() { }

	[Address(RVA = "0x1D417A0", Offset = "0x1D40BA0", Length = "0xB")]
	[Token(Token = "0x600065D")]
	public virtual bool IsHorming() { }

	[Address(RVA = "0x1D417B0", Offset = "0x1D40BB0", Length = "0x356")]
	[Token(Token = "0x600065E")]
	public void ProgressMoveJewel(float dt, Vector3 tsub) { }

	[Address(RVA = "0xE26DC0", Offset = "0xE261C0", Length = "0x7")]
	[Token(Token = "0x600065B")]
	public void StartHorming(int tno) { }

	[Address(RVA = "0x1D41B10", Offset = "0x1D40F10", Length = "0xF7")]
	[Token(Token = "0x600065A")]
	public void StartJewelMove(Vector3 s) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600065F")]
	public virtual void UpdatePosition() { }

}

