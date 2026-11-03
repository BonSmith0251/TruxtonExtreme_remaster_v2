namespace UnityEngine.InputSystem.Processors;

[DesignTimeVisible(False)]
[Token(Token = "0x20001EF")]
internal class CompensateRotationProcessor : InputProcessor<Quaternion>
{

	[Token(Token = "0x17000543")]
	public virtual CachingPolicy cachingPolicy
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6001260")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2A036C0", Offset = "0x2A02AC0", Length = "0x39")]
	[Token(Token = "0x6001261")]
	public CompensateRotationProcessor() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6001260")]
	public virtual CachingPolicy get_cachingPolicy() { }

	[Address(RVA = "0x2A033F0", Offset = "0x2A027F0", Length = "0x29E")]
	[Token(Token = "0x600125E")]
	public virtual Quaternion Process(Quaternion value, InputControl control) { }

	[Address(RVA = "0x2A03690", Offset = "0x2A02A90", Length = "0x2C")]
	[Token(Token = "0x600125F")]
	public virtual string ToString() { }

}

