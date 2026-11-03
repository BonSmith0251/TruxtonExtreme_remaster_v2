namespace UnityEngine.InputSystem;

[Token(Token = "0x2000058")]
public abstract class InputBindingComposite : InputBindingComposite
{

	[Token(Token = "0x1700013B")]
	public virtual int valueSizeInBytes
	{
		[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
		[Token(Token = "0x600041F")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700013A")]
	public virtual Type valueType
	{
		[Address(RVA = "0xE36D40", Offset = "0xE36140", Length = "0x38")]
		[Token(Token = "0x600041E")]
		 get { } //Length: 56
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000423")]
	protected InputBindingComposite`1() { }

	[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
	[Token(Token = "0x600041F")]
	public virtual int get_valueSizeInBytes() { }

	[Address(RVA = "0xE36D40", Offset = "0xE36140", Length = "0x38")]
	[Token(Token = "0x600041E")]
	public virtual Type get_valueType() { }

	[Token(Token = "0x6000420")]
	public abstract TValue ReadValue(ref InputBindingCompositeContext context) { }

	[Address(RVA = "0x1CA0FF0", Offset = "0x1CA03F0", Length = "0x15F")]
	[Token(Token = "0x6000421")]
	public virtual void ReadValue(ref InputBindingCompositeContext context, Void* buffer, int bufferSize) { }

	[Address(RVA = "0x1CA0F80", Offset = "0x1CA0380", Length = "0x66")]
	[Token(Token = "0x6000422")]
	public virtual object ReadValueAsObject(ref InputBindingCompositeContext context) { }

}

