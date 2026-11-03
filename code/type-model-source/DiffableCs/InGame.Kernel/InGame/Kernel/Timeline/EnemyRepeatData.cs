namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000E1")]
public class EnemyRepeatData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400060F")]
	public int _repeatTimes; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000610")]
	public Vector3 _offsetStep; //Field offset: 0x14
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000611")]
	public float _delayStep; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000612")]
	public float _speedStep; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000613")]
	public RepeatAttribute attributeFlag; //Field offset: 0x28

	[Address(RVA = "0x1D357F0", Offset = "0x1D34BF0", Length = "0x51")]
	[Token(Token = "0x6000750")]
	public EnemyRepeatData() { }

}

