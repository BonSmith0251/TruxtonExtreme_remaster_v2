namespace UnityEngine.Experimental.Playables;

[NativeHeader("Runtime/Graphics/Director/TextureMixerPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Export/Director/TextureMixerPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("TextureMixerPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200041C")]
public struct TextureMixerPlayable : IPlayable, IEquatable<TextureMixerPlayable>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E11")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x30CFD40", Offset = "0x30CF140", Length = "0x79")]
	[Token(Token = "0x6001F58")]
	public override bool Equals(TextureMixerPlayable other) { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x6001F57")]
	public override PlayableHandle GetHandle() { }

}

