namespace UnityEngine.Experimental.Rendering;

[RequiredByNativeCode]
[Token(Token = "0x2000421")]
internal class ScriptableRuntimeReflectionSystemWrapper
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E14")]
	private IScriptableRuntimeReflectionSystem <implementation>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170004AA")]
	internal IScriptableRuntimeReflectionSystem implementation
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001F65")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001F66")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001F68")]
	public ScriptableRuntimeReflectionSystemWrapper() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001F65")]
	internal IScriptableRuntimeReflectionSystem get_implementation() { }

	[Address(RVA = "0x30CB7B0", Offset = "0x30CABB0", Length = "0xC3")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001F67")]
	private void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(out bool result) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001F66")]
	internal void set_implementation(IScriptableRuntimeReflectionSystem value) { }

}

