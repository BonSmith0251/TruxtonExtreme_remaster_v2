namespace UnityEngine.Rendering;

[AttributeUsage(AttributeTargets::Field (256), Inherited = True)]
[Token(Token = "0x200037D")]
public abstract class ResourcePathsBaseAttribute : Attribute
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6001A52")]
	protected ResourcePathsBaseAttribute(String[] paths, bool isField, SearchType location) { }

}

