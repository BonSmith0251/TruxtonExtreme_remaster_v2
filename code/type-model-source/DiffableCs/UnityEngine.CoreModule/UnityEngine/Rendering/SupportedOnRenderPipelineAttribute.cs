namespace UnityEngine.Rendering;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False)]
[Token(Token = "0x2000392")]
public class SupportedOnRenderPipelineAttribute : Attribute
{
	[CompilerGenerated]
	[Token(Token = "0x2000394")]
	private sealed class <>c
	{
		[Token(Token = "0x4000AB5")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000AB6")]
		public static Func<Type, String> <>9__6_0; //Field offset: 0x8

		[Address(RVA = "0x30B91B0", Offset = "0x30B85B0", Length = "0x67")]
		[Token(Token = "0x6001CCB")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001CCC")]
		public <>c() { }

		[Address(RVA = "0x30B84D0", Offset = "0x30B78D0", Length = "0xCC")]
		[Token(Token = "0x6001CCE")]
		internal Type[] <.cctor>b__12_0() { }

		[Address(RVA = "0xA4D5F0", Offset = "0xA4C9F0", Length = "0x2C")]
		[Token(Token = "0x6001CCD")]
		internal string <.ctor>b__6_0(Type t) { }

	}

	[Token(Token = "0x2000393")]
	internal enum SupportedMode : int
	{
		Unsupported = 0,
		Supported = 1,
		SupportedByBaseClass = 2,
	}

	[Token(Token = "0x4000AAF")]
	private static readonly Lazy<Type[]> k_DefaultRenderPipelineAsset; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AB0")]
	private readonly Type[] <renderPipelineTypes>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170003EC")]
	public Type[] renderPipelineTypes
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001CC4")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x30B8000", Offset = "0x30B7400", Length = "0x101")]
	[Token(Token = "0x6001CCA")]
	private static SupportedOnRenderPipelineAttribute() { }

	[Address(RVA = "0x30B8410", Offset = "0x30B7810", Length = "0xB1")]
	[Token(Token = "0x6001CC5")]
	public SupportedOnRenderPipelineAttribute(Type renderPipeline) { }

	[Address(RVA = "0x30B8110", Offset = "0x30B7510", Length = "0x2FE")]
	[Token(Token = "0x6001CC6")]
	public SupportedOnRenderPipelineAttribute(Type[] renderPipeline) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001CC4")]
	public Type[] get_renderPipelineTypes() { }

	[Address(RVA = "0x30B7C80", Offset = "0x30B7080", Length = "0x195")]
	[Token(Token = "0x6001CC7")]
	public SupportedMode GetSupportedMode(Type renderPipelineAssetType) { }

	[Address(RVA = "0x30B7E20", Offset = "0x30B7220", Length = "0x165")]
	[Token(Token = "0x6001CC8")]
	internal static SupportedMode GetSupportedMode(Type[] renderPipelineTypes, Type renderPipelineAssetType) { }

	[Address(RVA = "0x30B7F90", Offset = "0x30B7390", Length = "0x6E")]
	[Token(Token = "0x6001CC9")]
	public static bool IsTypeSupportedOnRenderPipeline(Type type, Type renderPipelineAssetType) { }

}

