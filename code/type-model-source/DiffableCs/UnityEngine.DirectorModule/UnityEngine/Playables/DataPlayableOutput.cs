namespace UnityEngine.Playables;

[NativeHeader("Modules/Director/ScriptBindings/DataPlayableOutput.bindings.h")]
[NativeHeader("Modules/Director/ScriptBindings/DataPlayableOutputExtensions.bindings.h")]
[NativeHeader("Modules/Director/DataPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[RequiredByNativeCode]
[StaticAccessor("DataPlayableOutputBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000002")]
internal struct DataPlayableOutput : IPlayableOutput
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000001")]
	private PlayableOutputHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x30D17D0", Offset = "0x30D0BD0", Length = "0xDC")]
	[Token(Token = "0x6000001")]
	internal DataPlayableOutput(PlayableOutputHandle handle) { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x6000002")]
	public override PlayableOutputHandle GetHandle() { }

	[Address(RVA = "0x30D1580", Offset = "0x30D0980", Length = "0x24F")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000003")]
	private static void Internal_CallOnPlayerChanged(PlayableOutputHandle handle, object previousPlayer, object currentPlayer) { }

}

