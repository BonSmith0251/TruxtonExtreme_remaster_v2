namespace InGame.Kernel.Player;

[Token(Token = "0x2000122")]
public class SuperFighterOptionClamp
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000824")]
	private PlayerDefinedFighterOptions _playerDefinedFighterOptions; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000825")]
	private int _optionIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000826")]
	private float _easingStartPositionLeft; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000827")]
	private float _easingStartPositionRight; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000828")]
	private float _easingStartPositionBottom; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000829")]
	private float _previousEdgePositionLeft; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400082A")]
	private float _previousEdgePositionRight; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400082B")]
	private float _previousEdgePositionBottom; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400082C")]
	private float _easingTimeLeft; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400082D")]
	private float _easingTimeRight; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400082E")]
	private float _easingTimeBottom; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400082F")]
	private Vector3 _rightUpClampPosition; //Field offset: 0x40
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000830")]
	private Vector3 _leftBottomClampPosition; //Field offset: 0x4C

	[Address(RVA = "0x1D517B0", Offset = "0x1D50BB0", Length = "0x112")]
	[Token(Token = "0x600091B")]
	public SuperFighterOptionClamp(PlayerDefinedFighterOptions playerDefinedFighterOptions, int optionIndex) { }

	[Address(RVA = "0x1D51410", Offset = "0x1D50810", Length = "0x394")]
	[Token(Token = "0x600091C")]
	public ValueTuple<Vector3, Vector3> CalcScreenClamp(Vector3 fighterDeltaVector, float deltaTime) { }

}

