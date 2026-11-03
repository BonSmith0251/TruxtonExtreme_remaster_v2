namespace UnityEngine.Rendering.Universal;

[AttributeUsage(AttributeTargets::Field (256))]
[Token(Token = "0x20001D7")]
internal sealed class RenderPathCompatibleAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A35")]
	public RenderPathCompatibility renderPath; //Field offset: 0x10

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6000A15")]
	public RenderPathCompatibleAttribute(RenderPathCompatibility renderPath) { }

}

