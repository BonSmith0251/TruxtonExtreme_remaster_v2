namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/ScriptableProcessors/ScriptBindings/ScriptableProcessor.bindings.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000014")]
public struct ControlContext
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002D")]
	private ControlHeader* m_Header; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400002E")]
	internal Handle m_Handle; //Field offset: 0x8

	[Address(RVA = "0x2FCA560", Offset = "0x2FC9960", Length = "0x3A")]
	[Token(Token = "0x6000089")]
	internal ControlContext(Void* headerThatShouldBeOfResourceType) { }

	[Address(RVA = "0x2FCA440", Offset = "0x2FC9840", Length = "0x3A")]
	[RequiredByNativeCode(GenerateProxy = True)]
	[Token(Token = "0x600008C")]
	internal static void CleanupHeader(ref ControlHeader header) { }

	[Address(RVA = "0x2FCA480", Offset = "0x2FC9880", Length = "0x65")]
	[Token(Token = "0x600008A")]
	public bool Exists(ProcessorInstance processorInstance) { }

	[Address(RVA = "0x2FCA4F0", Offset = "0x2FC98F0", Length = "0x66")]
	[Token(Token = "0x600008B")]
	public Configuration GetConfiguration(GeneratorInstance generatorInstance) { }

}

