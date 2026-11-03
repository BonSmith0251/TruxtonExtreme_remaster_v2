namespace UnityEngine.Rendering.Universal;

[AttributeUsage(AttributeTargets::Class (4))]
[Token(Token = "0x20001AE")]
public class SupportedOnRendererAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000949")]
	private readonly Type[] <rendererTypes>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700022A")]
	public Type[] rendererTypes
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000951")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2DF1780", Offset = "0x2DF0B80", Length = "0x1D7")]
	[Token(Token = "0x6000952")]
	public SupportedOnRendererAttribute(Type renderer) { }

	[Address(RVA = "0x2DF1960", Offset = "0x2DF0D60", Length = "0x199")]
	[Token(Token = "0x6000953")]
	public SupportedOnRendererAttribute(Type[] renderers) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000951")]
	public Type[] get_rendererTypes() { }

}

