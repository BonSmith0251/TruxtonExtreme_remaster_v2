namespace UnityEngine.Animations;

[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationStream.bindings.h")]
[RequiredByNativeCode]
[Token(Token = "0x200003A")]
public struct AnimationStream
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000E0")]
	private uint m_AnimatorBindingsVersion; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000E1")]
	private IntPtr constant; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000E2")]
	private IntPtr input; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000E3")]
	private IntPtr output; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000E4")]
	private IntPtr workspace; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000E5")]
	private IntPtr inputStreamAccessor; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000E6")]
	private IntPtr animationHandleBinder; //Field offset: 0x30

}

