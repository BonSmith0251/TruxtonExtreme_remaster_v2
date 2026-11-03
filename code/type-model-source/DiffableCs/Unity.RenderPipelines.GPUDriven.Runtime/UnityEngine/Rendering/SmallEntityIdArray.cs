namespace UnityEngine.Rendering;

[DefaultMember("Item")]
[Token(Token = "0x200007E")]
internal struct SmallEntityIdArray : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400024D")]
	private FixedList32Bytes<EntityId> m_FixedArray; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400024E")]
	private UnsafeList<EntityId> m_List; //Field offset: 0x20
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400024F")]
	private readonly bool m_IsEmbedded; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000250")]
	private bool <Valid>k__BackingField; //Field offset: 0x39
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000251")]
	public readonly int Length; //Field offset: 0x3C

	[Token(Token = "0x17000049")]
	public EntityId Item
	{
		[Address(RVA = "0x2CF09F0", Offset = "0x2CEFDF0", Length = "0xAC")]
		[Token(Token = "0x6000287")]
		 get { } //Length: 172
		[Address(RVA = "0x2CF0AA0", Offset = "0x2CEFEA0", Length = "0xBE")]
		[Token(Token = "0x6000288")]
		 set { } //Length: 190
	}

	[Token(Token = "0x17000048")]
	public private bool Valid
	{
		[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000284")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDC90", Offset = "0x11ED090", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000285")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2CF0850", Offset = "0x2CEFC50", Length = "0x197")]
	[Token(Token = "0x6000286")]
	public SmallEntityIdArray(int length, Allocator allocator) { }

	[Address(RVA = "0x2CF0800", Offset = "0x2CEFC00", Length = "0x45")]
	[Token(Token = "0x6000289")]
	public override void Dispose() { }

	[Address(RVA = "0x2CF09F0", Offset = "0x2CEFDF0", Length = "0xAC")]
	[Token(Token = "0x6000287")]
	public EntityId get_Item(int index) { }

	[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000284")]
	public bool get_Valid() { }

	[Address(RVA = "0x2CF0AA0", Offset = "0x2CEFEA0", Length = "0xBE")]
	[Token(Token = "0x6000288")]
	public void set_Item(int index, EntityId value) { }

	[Address(RVA = "0x11EDC90", Offset = "0x11ED090", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000285")]
	private void set_Valid(bool value) { }

}

