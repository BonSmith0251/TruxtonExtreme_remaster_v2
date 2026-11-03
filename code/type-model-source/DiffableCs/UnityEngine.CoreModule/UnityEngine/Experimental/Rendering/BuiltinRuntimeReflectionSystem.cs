namespace UnityEngine.Experimental.Rendering;

[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
[Token(Token = "0x200041E")]
internal class BuiltinRuntimeReflectionSystem : IScriptableRuntimeReflectionSystem, IDisposable
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001F5F")]
	public BuiltinRuntimeReflectionSystem() { }

	[Address(RVA = "0x30B9FD0", Offset = "0x30B93D0", Length = "0x2A")]
	[StaticAccessor("GetReflectionProbes()", Type = StaticAccessorType::Dot (0))]
	[Token(Token = "0x6001F5D")]
	private static bool BuiltinUpdate() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001F5B")]
	public override void Dispose() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001F5C")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x30BA000", Offset = "0x30B9400", Length = "0x44")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001F5E")]
	private static BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New() { }

	[Address(RVA = "0x30B9FD0", Offset = "0x30B93D0", Length = "0x2A")]
	[Token(Token = "0x6001F5A")]
	public override bool TickRealtimeProbes() { }

}

