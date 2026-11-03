namespace Unity.Properties;

[Token(Token = "0x2000011")]
public sealed class PropertySetter : MulticastDelegate
{

	[Address(RVA = "0xE420C0", Offset = "0xE414C0", Length = "0xB9")]
	[Token(Token = "0x6000025")]
	public PropertySetter`2(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000026")]
	public override void Invoke(ref TContainer container, TValue value) { }

}

