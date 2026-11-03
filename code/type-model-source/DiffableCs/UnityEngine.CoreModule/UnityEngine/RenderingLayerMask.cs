namespace UnityEngine;

[NativeClass("RenderingLayerMask", "struct RenderingLayerMask;")]
[NativeHeader("Runtime/BaseClasses/TagManager.h")]
[NativeHeader("Runtime/Graphics/RenderingLayerMask.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x2000178")]
public struct RenderingLayerMask
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000614")]
	private static readonly RenderingLayerMask <defaultRenderingLayerMask>k__BackingField; //Field offset: 0x0
	[Token(Token = "0x4000615")]
	internal const int maxRenderingLayerSize = 32; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[NativeName("m_Bits")]
	[Token(Token = "0x4000613")]
	private uint m_Bits; //Field offset: 0x0

	[Token(Token = "0x170002C0")]
	public static RenderingLayerMask defaultRenderingLayerMask
	{
		[Address(RVA = "0x306FDC0", Offset = "0x306F1C0", Length = "0x4D")]
		[CompilerGenerated]
		[Token(Token = "0x600121F")]
		 get { } //Length: 77
	}

	[Address(RVA = "0x306FD80", Offset = "0x306F180", Length = "0x39")]
	[Token(Token = "0x6001229")]
	private static RenderingLayerMask() { }

	[Address(RVA = "0x306FDC0", Offset = "0x306F1C0", Length = "0x4D")]
	[CompilerGenerated]
	[Token(Token = "0x600121F")]
	public static RenderingLayerMask get_defaultRenderingLayerMask() { }

	[Address(RVA = "0x306FB90", Offset = "0x306EF90", Length = "0x2A")]
	[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x6001225")]
	public static int GetDefinedRenderingLayerCount() { }

	[Address(RVA = "0x306FBC0", Offset = "0x306EFC0", Length = "0x2A")]
	[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x6001227")]
	public static String[] GetDefinedRenderingLayerNames() { }

	[Address(RVA = "0x306FBF0", Offset = "0x306EFF0", Length = "0x2A")]
	[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x6001226")]
	public static uint GetDefinedRenderingLayersCombinedMaskValue() { }

	[Address(RVA = "0x306FC20", Offset = "0x306F020", Length = "0x2A")]
	[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x6001228")]
	public static int GetRenderingLayerCount() { }

	[Address(RVA = "0x30659A0", Offset = "0x3064DA0", Length = "0x5")]
	[Token(Token = "0x6001220")]
	public static uint op_Implicit(RenderingLayerMask mask) { }

	[Address(RVA = "0x30659A0", Offset = "0x3064DA0", Length = "0x5")]
	[Token(Token = "0x6001221")]
	public static RenderingLayerMask op_Implicit(uint intVal) { }

	[Address(RVA = "0x30659A0", Offset = "0x3064DA0", Length = "0x5")]
	[Token(Token = "0x6001222")]
	public static int op_Implicit(RenderingLayerMask mask) { }

	[Address(RVA = "0x30659A0", Offset = "0x3064DA0", Length = "0x5")]
	[Token(Token = "0x6001223")]
	public static RenderingLayerMask op_Implicit(int intVal) { }

	[Address(RVA = "0x306FC90", Offset = "0x306F090", Length = "0xE5")]
	[NativeMethod("RenderingLayerToString")]
	[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x6001224")]
	public static string RenderingLayerToName(int layer) { }

	[Address(RVA = "0x306FC50", Offset = "0x306F050", Length = "0x40")]
	[Token(Token = "0x600122A")]
	private static void RenderingLayerToName_Injected(int layer, out ManagedSpanWrapper ret) { }

}

