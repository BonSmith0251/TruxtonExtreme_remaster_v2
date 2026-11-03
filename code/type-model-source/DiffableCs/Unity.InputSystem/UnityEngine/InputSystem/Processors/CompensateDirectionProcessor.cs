namespace UnityEngine.InputSystem.Processors;

[DesignTimeVisible(False)]
[Token(Token = "0x20001EE")]
internal class CompensateDirectionProcessor : InputProcessor<Vector3>
{

	[Token(Token = "0x17000542")]
	public virtual CachingPolicy cachingPolicy
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600125C")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2A033B0", Offset = "0x2A027B0", Length = "0x39")]
	[Token(Token = "0x600125D")]
	public CompensateDirectionProcessor() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600125C")]
	public virtual CachingPolicy get_cachingPolicy() { }

	[Address(RVA = "0x2A03200", Offset = "0x2A02600", Length = "0x17A")]
	[Token(Token = "0x600125A")]
	public virtual Vector3 Process(Vector3 value, InputControl control) { }

	[Address(RVA = "0x2A03380", Offset = "0x2A02780", Length = "0x2C")]
	[Token(Token = "0x600125B")]
	public virtual string ToString() { }

}

