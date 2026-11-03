namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001A6")]
public static class ShaderUtils
{
	[CompilerGenerated]
	[Token(Token = "0x20001A7")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400093A")]
		public string path; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000919")]
		public <>c__DisplayClass2_0() { }

		[Address(RVA = "0x2DFB110", Offset = "0x2DFA510", Length = "0x12")]
		[Token(Token = "0x600091A")]
		internal bool <GetEnumFromPath>b__0(string m) { }

	}

	[Token(Token = "0x4000939")]
	private static readonly String[] s_ShaderPaths; //Field offset: 0x0

	[Token(Token = "0x17000229")]
	internal static float PersistentDeltaTime
	{
		[Address(RVA = "0x1E15BA0", Offset = "0x1E14FA0", Length = "0x7")]
		[Token(Token = "0x6000917")]
		internal get { } //Length: 7
	}

	[Address(RVA = "0x2DEBDD0", Offset = "0x2DEB1D0", Length = "0x2A2")]
	[Token(Token = "0x6000918")]
	private static ShaderUtils() { }

	[Address(RVA = "0x1E15BA0", Offset = "0x1E14FA0", Length = "0x7")]
	[Token(Token = "0x6000917")]
	internal static float get_PersistentDeltaTime() { }

	[Address(RVA = "0x2DEB9F0", Offset = "0x2DEADF0", Length = "0x103")]
	[Token(Token = "0x6000915")]
	public static ShaderPathID GetEnumFromPath(string path) { }

	[Address(RVA = "0x2DEBB00", Offset = "0x2DEAF00", Length = "0x231")]
	[Token(Token = "0x6000914")]
	public static string GetShaderPath(ShaderPathID id) { }

	[Address(RVA = "0x2DEBD40", Offset = "0x2DEB140", Length = "0x8E")]
	[Token(Token = "0x6000916")]
	public static bool IsLWShader(Shader shader) { }

}

