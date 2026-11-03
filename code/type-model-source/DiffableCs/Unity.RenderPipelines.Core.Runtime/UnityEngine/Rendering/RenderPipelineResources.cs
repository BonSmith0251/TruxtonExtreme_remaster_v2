namespace UnityEngine.Rendering;

[Token(Token = "0x2000166")]
public abstract class RenderPipelineResources : ScriptableObject
{

	[Token(Token = "0x17000154")]
	protected override string packagePath
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000B5F")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000155")]
	internal string packagePath_Internal
	{
		[Address(RVA = "0x22918F0", Offset = "0x2290CF0", Length = "0x14")]
		[Token(Token = "0x6000B60")]
		internal get { } //Length: 20
	}

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x6000B61")]
	protected RenderPipelineResources() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000B5F")]
	protected override string get_packagePath() { }

	[Address(RVA = "0x22918F0", Offset = "0x2290CF0", Length = "0x14")]
	[Token(Token = "0x6000B60")]
	internal string get_packagePath_Internal() { }

}

