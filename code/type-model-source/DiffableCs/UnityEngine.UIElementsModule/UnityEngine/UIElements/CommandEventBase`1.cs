namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Command (15))]
[Token(Token = "0x20001BE")]
public abstract class CommandEventBase : EventBase<T>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000804")]
	private string m_CommandName; //Field offset: 0x0

	[Token(Token = "0x1700023F")]
	public override string commandName
	{
		[Address(RVA = "0x16D9570", Offset = "0x16D8970", Length = "0x49")]
		[Token(Token = "0x6000C9C")]
		 get { } //Length: 73
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[Token(Token = "0x6000C9D")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x16D94E0", Offset = "0x16D88E0", Length = "0x86")]
	[Token(Token = "0x6000CA3")]
	protected CommandEventBase`1() { }

	[Address(RVA = "0xAF03B0", Offset = "0xAEF7B0", Length = "0x8")]
	[Token(Token = "0x6000CA2")]
	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x16D9570", Offset = "0x16D8970", Length = "0x49")]
	[Token(Token = "0x6000C9C")]
	public override string get_commandName() { }

	[Address(RVA = "0x16D93B0", Offset = "0x16D87B0", Length = "0xA0")]
	[Token(Token = "0x6000CA0")]
	public static T GetPooled(Event systemEvent) { }

	[Address(RVA = "0x16D92F0", Offset = "0x16D86F0", Length = "0xBE")]
	[Token(Token = "0x6000CA1")]
	public static T GetPooled(string commandName) { }

	[Address(RVA = "0x16D9460", Offset = "0x16D8860", Length = "0x46")]
	[Token(Token = "0x6000C9E")]
	protected virtual void Init() { }

	[Address(RVA = "0x16D94B0", Offset = "0x16D88B0", Length = "0x2C")]
	[Token(Token = "0x6000C9F")]
	private void LocalInit() { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x6000C9D")]
	protected void set_commandName(string value) { }

}

