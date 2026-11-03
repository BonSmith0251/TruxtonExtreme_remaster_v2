namespace UnityEngine.Experimental.Playables;

[NativeHeader("Runtime/Export/Director/TexturePlayableOutput.bindings.h")]
[NativeHeader("Runtime/Graphics/Director/TexturePlayableOutput.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[RequiredByNativeCode]
[StaticAccessor("TexturePlayableOutputBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200041D")]
public struct TexturePlayableOutput : IPlayableOutput
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E12")]
	private PlayableOutputHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x6001F59")]
	public override PlayableOutputHandle GetHandle() { }

}

