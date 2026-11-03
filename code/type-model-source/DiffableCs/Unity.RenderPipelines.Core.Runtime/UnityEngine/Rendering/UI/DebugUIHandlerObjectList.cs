namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002E4")]
public class DebugUIHandlerObjectList : DebugUIHandlerField<ObjectListField>
{
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000D60")]
	private int m_Index; //Field offset: 0x88

	[Address(RVA = "0x2CB2D20", Offset = "0x2CB2120", Length = "0x39")]
	[Token(Token = "0x6001463")]
	public DebugUIHandlerObjectList() { }

	[Address(RVA = "0x2CB2B20", Offset = "0x2CB1F20", Length = "0x1A")]
	[Token(Token = "0x6001461")]
	public virtual void OnDecrement(bool fast) { }

	[Address(RVA = "0x2CB2B40", Offset = "0x2CB1F40", Length = "0x1A")]
	[Token(Token = "0x6001460")]
	public virtual void OnIncrement(bool fast) { }

	[Address(RVA = "0x2CB2B60", Offset = "0x2CB1F60", Length = "0x53")]
	[Token(Token = "0x600145F")]
	internal virtual void SetWidget(Widget widget) { }

	[Address(RVA = "0x2CB2BC0", Offset = "0x2CB1FC0", Length = "0x157")]
	[Token(Token = "0x6001462")]
	public virtual void UpdateValueLabel() { }

}

