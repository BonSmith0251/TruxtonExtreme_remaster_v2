namespace UnityEngine.Rendering.RenderGraphModule;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
[Token(Token = "0x200026B")]
public class InternalRenderGraphContext
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AF0")]
	internal ScriptableRenderContext renderContext; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000AF1")]
	internal CommandBuffer cmd; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000AF2")]
	internal RenderGraphObjectPool renderGraphPool; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000AF3")]
	internal RenderGraphDefaultResources defaultResources; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000AF4")]
	internal RenderGraphPass executingPass; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000AF5")]
	internal CompilerContextData compilerContext; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000AF6")]
	internal bool contextlessTesting; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x4000AF7")]
	internal bool forceResourceCreation; //Field offset: 0x41

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001110")]
	public InternalRenderGraphContext() { }

}

