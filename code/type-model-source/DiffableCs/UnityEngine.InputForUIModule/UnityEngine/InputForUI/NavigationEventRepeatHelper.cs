namespace UnityEngine.InputForUI;

[Token(Token = "0x200002B")]
internal class NavigationEventRepeatHelper
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D4")]
	private int m_ConsecutiveMoveCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000D5")]
	private Direction m_LastDirection; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000D6")]
	private DiscreteTime m_PrevActionTime; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D7")]
	private readonly DiscreteTime m_InitialRepeatDelay; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000D8")]
	private readonly DiscreteTime m_ConsecutiveRepeatDelay; //Field offset: 0x28

	[Address(RVA = "0x310E8C0", Offset = "0x310DCC0", Length = "0xA6")]
	[Token(Token = "0x60000D7")]
	public NavigationEventRepeatHelper() { }

	[Address(RVA = "0x310E760", Offset = "0x310DB60", Length = "0x5E")]
	[Token(Token = "0x60000D5")]
	public void Reset() { }

	[Address(RVA = "0x310E7C0", Offset = "0x310DBC0", Length = "0xF3")]
	[Token(Token = "0x60000D6")]
	public bool ShouldSendMoveEvent(DiscreteTime timestamp, Direction direction, bool axisButtonsWherePressedThisFrame) { }

}

