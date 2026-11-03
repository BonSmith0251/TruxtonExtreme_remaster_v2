//Type is in global namespace

[Token(Token = "0x2000002")]
internal class VisualEffectActivationBehaviour : PlayableBehaviour
{
	[Token(Token = "0x2000003")]
	internal enum AttributeType : int
	{
		Float = 1,
		Float2 = 2,
		Float3 = 3,
		Float4 = 4,
		Int32 = 5,
		Uint32 = 6,
		Boolean = 17,
	}

	[Token(Token = "0x2000004")]
	internal struct EventState
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400000D")]
		public ExposedProperty attribute; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400000E")]
		public AttributeType type; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400000F")]
		public Single[] values; //Field offset: 0x10

	}

	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000001")]
	public ExposedProperty onClipEnter; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000002")]
	public ExposedProperty onClipExit; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000003")]
	public EventState[] clipEnterEventAttributes; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000004")]
	public EventState[] clipExitEventAttributes; //Field offset: 0x28

	[Address(RVA = "0x2F78EE0", Offset = "0x2F782E0", Length = "0x119")]
	[Token(Token = "0x6000001")]
	public VisualEffectActivationBehaviour() { }

}

