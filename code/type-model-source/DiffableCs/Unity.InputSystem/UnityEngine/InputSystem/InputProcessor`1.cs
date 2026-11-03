namespace UnityEngine.InputSystem;

[Token(Token = "0x2000087")]
public abstract class InputProcessor : InputProcessor
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000638")]
	protected InputProcessor`1() { }

	[Token(Token = "0x6000635")]
	public abstract TValue Process(TValue value, InputControl control) { }

	[Address(RVA = "0x1CB7CF0", Offset = "0x1CB70F0", Length = "0x1B6")]
	[Token(Token = "0x6000637")]
	public virtual void Process(Void* buffer, int bufferSize, InputControl control) { }

	[Address(RVA = "0x1CB6B70", Offset = "0x1CB5F70", Length = "0x233")]
	[Token(Token = "0x6000636")]
	public virtual object ProcessAsObject(object value, InputControl control) { }

}

