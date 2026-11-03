namespace UnityEngine.Experimental.Playables;

[NativeHeader("Runtime/Camera//Director/CameraPlayable.h")]
[NativeHeader("Runtime/Export/Director/CameraPlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("CameraPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200041A")]
public struct CameraPlayable : IPlayable, IEquatable<CameraPlayable>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E0F")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x30BA050", Offset = "0x30B9450", Length = "0x79")]
	[Token(Token = "0x6001F54")]
	public override bool Equals(CameraPlayable other) { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x6001F53")]
	public override PlayableHandle GetHandle() { }

}

