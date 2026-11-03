namespace UnityEngine;

[Token(Token = "0x200017C")]
public class ResourcesAPI
{
	[Token(Token = "0x4000618")]
	private static ResourcesAPI s_DefaultAPI; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000619")]
	private static ResourcesAPI <overrideAPI>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x170002C2")]
	internal static ResourcesAPI ActiveAPI
	{
		[Address(RVA = "0x3070A40", Offset = "0x306FE40", Length = "0xA7")]
		[Token(Token = "0x600123A")]
		internal get { } //Length: 167
	}

	[Token(Token = "0x170002C3")]
	public static ResourcesAPI overrideAPI
	{
		[Address(RVA = "0x3070AF0", Offset = "0x306FEF0", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x600123B")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x30709D0", Offset = "0x306FDD0", Length = "0x67")]
	[Token(Token = "0x6001243")]
	private static ResourcesAPI() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600123C")]
	protected private ResourcesAPI() { }

	[Address(RVA = "0x3070860", Offset = "0x306FC60", Length = "0x33")]
	[Token(Token = "0x600123D")]
	protected private override Object[] FindObjectsOfTypeAll(Type systemTypeInstance) { }

	[Address(RVA = "0x30708A0", Offset = "0x306FCA0", Length = "0xA")]
	[Token(Token = "0x600123E")]
	protected private override Shader FindShaderByName(string name) { }

	[Address(RVA = "0x3070A40", Offset = "0x306FE40", Length = "0xA7")]
	[Token(Token = "0x600123A")]
	internal static ResourcesAPI get_ActiveAPI() { }

	[Address(RVA = "0x3070AF0", Offset = "0x306FEF0", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x600123B")]
	public static ResourcesAPI get_overrideAPI() { }

	[Address(RVA = "0x3070940", Offset = "0x306FD40", Length = "0x11")]
	[Token(Token = "0x600123F")]
	protected private override object Load(string path, Type systemTypeInstance) { }

	[Address(RVA = "0x30708B0", Offset = "0x306FCB0", Length = "0x11")]
	[Token(Token = "0x6001240")]
	protected private override Object[] LoadAll(string path, Type systemTypeInstance) { }

	[Address(RVA = "0x30708D0", Offset = "0x306FCD0", Length = "0x63")]
	[Token(Token = "0x6001241")]
	protected private override ResourceRequest LoadAsync(string path, Type systemTypeInstance) { }

	[Address(RVA = "0x3070960", Offset = "0x306FD60", Length = "0x6B")]
	[Token(Token = "0x6001242")]
	protected private override void UnloadAsset(object assetToUnload) { }

}

