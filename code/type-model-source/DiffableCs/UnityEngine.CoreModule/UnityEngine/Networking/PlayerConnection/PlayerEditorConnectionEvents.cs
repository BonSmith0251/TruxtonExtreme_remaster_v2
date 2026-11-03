namespace UnityEngine.Networking.PlayerConnection;

[Token(Token = "0x200030C")]
internal class PlayerEditorConnectionEvents
{
	[Token(Token = "0x200030E")]
	internal class ConnectionChangeEvent : UnityEvent<Int32>
	{

		[Address(RVA = "0x3078300", Offset = "0x3077700", Length = "0x39")]
		[Token(Token = "0x60018D4")]
		public ConnectionChangeEvent() { }

	}

	[Token(Token = "0x200030D")]
	internal class MessageEvent : UnityEvent<MessageEventArgs>
	{

		[Address(RVA = "0x3079D80", Offset = "0x3079180", Length = "0x39")]
		[Token(Token = "0x60018D3")]
		public MessageEvent() { }

	}

	[Token(Token = "0x200030F")]
	internal class MessageTypeSubscribers
	{
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x400080A")]
		private string m_messageTypeId; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400080B")]
		public int subscriberCount; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400080C")]
		public MessageEvent messageCallback; //Field offset: 0x20

		[Token(Token = "0x1700039E")]
		public Guid MessageTypeId
		{
			[Address(RVA = "0x3079E50", Offset = "0x3079250", Length = "0x36")]
			[Token(Token = "0x60018D5")]
			 get { } //Length: 54
			[Address(RVA = "0x3079E90", Offset = "0x3079290", Length = "0x2C")]
			[Token(Token = "0x60018D6")]
			 set { } //Length: 44
		}

		[Address(RVA = "0x3079DC0", Offset = "0x30791C0", Length = "0x8E")]
		[Token(Token = "0x60018D7")]
		public MessageTypeSubscribers() { }

		[Address(RVA = "0x3079E50", Offset = "0x3079250", Length = "0x36")]
		[Token(Token = "0x60018D5")]
		public Guid get_MessageTypeId() { }

		[Address(RVA = "0x3079E90", Offset = "0x3079290", Length = "0x2C")]
		[Token(Token = "0x60018D6")]
		public void set_MessageTypeId(Guid value) { }

	}

	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000806")]
	private List<MessageTypeSubscribers> m_MessageTypeSubscribers; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000807")]
	private Dictionary<Guid, MessageTypeSubscribers> m_SubscriberLookup; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000808")]
	public ConnectionChangeEvent connectionEvent; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000809")]
	public ConnectionChangeEvent disconnectionEvent; //Field offset: 0x28

	[Token(Token = "0x1700039D")]
	public IReadOnlyList<MessageTypeSubscribers> messageTypeSubscribers
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60018CD")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x3080F40", Offset = "0x3080340", Length = "0x117")]
	[Token(Token = "0x60018D2")]
	public PlayerEditorConnectionEvents() { }

	[Address(RVA = "0x3080720", Offset = "0x307FB20", Length = "0x272")]
	[Token(Token = "0x60018D0")]
	public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId) { }

	[Address(RVA = "0x30809A0", Offset = "0x307FDA0", Length = "0x2E0")]
	[Token(Token = "0x60018CE")]
	private void BuildLookup() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60018CD")]
	public IReadOnlyList<MessageTypeSubscribers> get_messageTypeSubscribers() { }

	[Address(RVA = "0x3080C90", Offset = "0x3080090", Length = "0x173")]
	[Token(Token = "0x60018CF")]
	public void InvokeMessageIdSubscribers(Guid messageId, Byte[] data, int playerId) { }

	[Address(RVA = "0x3080E10", Offset = "0x3080210", Length = "0x125")]
	[Token(Token = "0x60018D1")]
	public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback) { }

}

