namespace UnityEngine.Experimental.Video;

[NativeHeader("Modules/Video/Public/ScriptBindings/VideoClipPlayable.bindings.h")]
[NativeHeader("Modules/Video/Public/Director/VideoClipPlayable.h")]
[NativeHeader("Modules/Video/Public/VideoClip.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("VideoClipPlayableBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000002")]
public struct VideoClipPlayable : IPlayable, IEquatable<VideoClipPlayable>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000001")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x348BA20", Offset = "0x348AE20", Length = "0x79")]
	[Token(Token = "0x6000002")]
	public override bool Equals(VideoClipPlayable other) { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x6000001")]
	public override PlayableHandle GetHandle() { }

}

