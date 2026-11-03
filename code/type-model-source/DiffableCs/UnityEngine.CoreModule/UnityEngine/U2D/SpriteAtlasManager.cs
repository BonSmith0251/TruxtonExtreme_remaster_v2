namespace UnityEngine.U2D;

[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlasManager.h")]
[StaticAccessor("GetSpriteAtlasManager()", StaticAccessorType::Dot (0))]
[Token(Token = "0x200043E")]
public class SpriteAtlasManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000F24")]
	private static Action<String, Action`1<SpriteAtlas>> atlasRequested; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000F25")]
	private static Action<SpriteAtlas> atlasRegistered; //Field offset: 0x8

	[Token(Token = "0x14000014")]
	public static event Action<SpriteAtlas> atlasRegistered
	{
		[Address(RVA = "0x30CD9A0", Offset = "0x30CCDA0", Length = "0xDF")]
		[CompilerGenerated]
		[Token(Token = "0x6001FAE")]
		 add { } //Length: 223
		[Address(RVA = "0x30CDB60", Offset = "0x30CCF60", Length = "0xDF")]
		[CompilerGenerated]
		[Token(Token = "0x6001FAF")]
		 remove { } //Length: 223
	}

	[Token(Token = "0x14000013")]
	public static event Action<String, Action`1<SpriteAtlas>> atlasRequested
	{
		[Address(RVA = "0x30CDA80", Offset = "0x30CCE80", Length = "0xD7")]
		[CompilerGenerated]
		[Token(Token = "0x6001FAB")]
		 add { } //Length: 215
		[Address(RVA = "0x30CDC40", Offset = "0x30CD040", Length = "0xD7")]
		[CompilerGenerated]
		[Token(Token = "0x6001FAC")]
		 remove { } //Length: 215
	}

	[Address(RVA = "0x30CD9A0", Offset = "0x30CCDA0", Length = "0xDF")]
	[CompilerGenerated]
	[Token(Token = "0x6001FAE")]
	public static void add_atlasRegistered(Action<SpriteAtlas> value) { }

	[Address(RVA = "0x30CDA80", Offset = "0x30CCE80", Length = "0xD7")]
	[CompilerGenerated]
	[Token(Token = "0x6001FAB")]
	public static void add_atlasRequested(Action<String, Action`1<SpriteAtlas>> value) { }

	[Address(RVA = "0x30CD7E0", Offset = "0x30CCBE0", Length = "0x59")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001FB0")]
	private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	[Address(RVA = "0x30CD880", Offset = "0x30CCC80", Length = "0x6B")]
	[Token(Token = "0x6001FB1")]
	internal static void Register(SpriteAtlas spriteAtlas) { }

	[Address(RVA = "0x30CD840", Offset = "0x30CCC40", Length = "0x33")]
	[Token(Token = "0x6001FB2")]
	private static void Register_Injected(IntPtr spriteAtlas) { }

	[Address(RVA = "0x30CDB60", Offset = "0x30CCF60", Length = "0xDF")]
	[CompilerGenerated]
	[Token(Token = "0x6001FAF")]
	public static void remove_atlasRegistered(Action<SpriteAtlas> value) { }

	[Address(RVA = "0x30CDC40", Offset = "0x30CD040", Length = "0xD7")]
	[CompilerGenerated]
	[Token(Token = "0x6001FAC")]
	public static void remove_atlasRequested(Action<String, Action`1<SpriteAtlas>> value) { }

	[Address(RVA = "0x30CD8F0", Offset = "0x30CCCF0", Length = "0xB0")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001FAD")]
	private static bool RequestAtlas(string tag) { }

}

