namespace Unity.Properties;

[Token(Token = "0x2000010")]
public sealed class PropertyGetter : MulticastDelegate
{

	[Address(RVA = "0xE42000", Offset = "0xE41400", Length = "0xB8")]
	[Token(Token = "0x6000023")]
	public PropertyGetter`2(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000024")]
	public override TValue Invoke(ref TContainer container) { }

}

