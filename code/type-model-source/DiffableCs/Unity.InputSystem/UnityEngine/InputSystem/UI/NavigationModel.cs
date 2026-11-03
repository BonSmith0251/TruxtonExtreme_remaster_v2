namespace UnityEngine.InputSystem.UI;

[Token(Token = "0x2000120")]
internal struct NavigationModel
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006AA")]
	public Vector2 move; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006AB")]
	public int consecutiveMoveCount; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40006AC")]
	public MoveDirection lastMoveDirection; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006AD")]
	public float lastMoveTime; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006AE")]
	public AxisEventData eventData; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006AF")]
	public InputDevice device; //Field offset: 0x20

	[Address(RVA = "0x29E1460", Offset = "0x29E0860", Length = "0x4B")]
	[Token(Token = "0x6000DD6")]
	public void Reset() { }

}

