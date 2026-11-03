namespace UnityEngine.Experimental.Playables;

[NativeHeader("Runtime/Export/Director/MaterialEffectPlayable.bindings.h")]
[NativeHeader("Runtime/Shaders/Director/MaterialEffectPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("MaterialEffectPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200041B")]
public struct MaterialEffectPlayable : IPlayable, IEquatable<MaterialEffectPlayable>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E10")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x30C3090", Offset = "0x30C2490", Length = "0x79")]
	[Token(Token = "0x6001F56")]
	public override bool Equals(MaterialEffectPlayable other) { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x6001F55")]
	public override PlayableHandle GetHandle() { }

}

