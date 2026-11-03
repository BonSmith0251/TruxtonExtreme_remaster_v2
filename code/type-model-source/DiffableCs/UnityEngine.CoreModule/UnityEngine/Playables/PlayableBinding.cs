namespace UnityEngine.Playables;

[Token(Token = "0x2000320")]
public struct PlayableBinding
{
	[Token(Token = "0x2000321")]
	[VisibleToOtherModules]
	public sealed class CreateOutputMethod : MulticastDelegate
	{

		[Address(RVA = "0x3078380", Offset = "0x3077780", Length = "0xA6")]
		[Token(Token = "0x600191D")]
		public CreateOutputMethod(object object, IntPtr method) { }

		[Address(RVA = "0x3078340", Offset = "0x3077740", Length = "0x3F")]
		[Token(Token = "0x600191E")]
		public override PlayableOutput Invoke(PlayableGraph graph, string name) { }

	}

	[Token(Token = "0x4000834")]
	public static readonly PlayableBinding[] None; //Field offset: 0x0
	[Token(Token = "0x4000835")]
	public static readonly double DefaultDuration; //Field offset: 0x8
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000830")]
	private string m_StreamName; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000831")]
	private object m_SourceObject; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000832")]
	private Type m_SourceBindingType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000833")]
	private CreateOutputMethod m_CreateOutputMethod; //Field offset: 0x18

	[Token(Token = "0x170003B0")]
	public object sourceObject
	{
		[Address(RVA = "0x20939E0", Offset = "0x2092DE0", Length = "0x7")]
		[Token(Token = "0x6001919")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x307C1E0", Offset = "0x307B5E0", Length = "0x82")]
	[Token(Token = "0x600191C")]
	private static PlayableBinding() { }

	[Address(RVA = "0x307C050", Offset = "0x307B450", Length = "0x9C")]
	[Token(Token = "0x600191B")]
	[VisibleToOtherModules]
	internal static PlayableBinding CreateInternal(string name, object sourceObject, Type sourceType, CreateOutputMethod createFunction) { }

	[Address(RVA = "0x307C0F0", Offset = "0x307B4F0", Length = "0xEA")]
	[Token(Token = "0x600191A")]
	internal PlayableOutput CreateOutput(PlayableGraph graph) { }

	[Address(RVA = "0x20939E0", Offset = "0x2092DE0", Length = "0x7")]
	[Token(Token = "0x6001919")]
	public object get_sourceObject() { }

}

