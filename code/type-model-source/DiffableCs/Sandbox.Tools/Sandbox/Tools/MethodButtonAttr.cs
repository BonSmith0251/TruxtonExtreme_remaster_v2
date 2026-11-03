namespace Sandbox.Tools;

[Token(Token = "0x2000004")]
public class MethodButtonAttr : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000006")]
	public string Method; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000007")]
	public string Name; //Field offset: 0x20

	[Address(RVA = "0x2228A20", Offset = "0x2227E20", Length = "0x55")]
	[Token(Token = "0x6000003")]
	public MethodButtonAttr(string method, string name) { }

}

