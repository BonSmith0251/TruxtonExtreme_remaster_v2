namespace UnityEngine;

[NativeHeader("Runtime/Export/Graphics/Graphics.bindings.h")]
[Token(Token = "0x20000E2")]
public sealed class LightProbes : object
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000279")]
	private static Action lightProbesUpdated; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400027A")]
	private static Action tetrahedralizationCompleted; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400027B")]
	private static Action needsRetetrahedralization; //Field offset: 0x10

	[Address(RVA = "0x2FF8CC0", Offset = "0x2FF80C0", Length = "0x4F")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000689")]
	private static void Internal_CallLightProbesUpdatedFunction() { }

	[Address(RVA = "0x2FF8D10", Offset = "0x2FF8110", Length = "0x51")]
	[RequiredByNativeCode]
	[Token(Token = "0x600068B")]
	private static void Internal_CallNeedsRetetrahedralizationFunction() { }

	[Address(RVA = "0x2FF8D70", Offset = "0x2FF8170", Length = "0x51")]
	[RequiredByNativeCode]
	[Token(Token = "0x600068A")]
	private static void Internal_CallTetrahedralizationCompletedFunction() { }

}

