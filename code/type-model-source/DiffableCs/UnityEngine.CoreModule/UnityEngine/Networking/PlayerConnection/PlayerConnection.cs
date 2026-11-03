namespace UnityEngine.Networking.PlayerConnection;

[Token(Token = "0x2000308")]
public class PlayerConnection : ScriptableObject, IEditorPlayerConnection
{
	[CompilerGenerated]
	[Token(Token = "0x2000309")]
	private sealed class <>c__DisplayClass12_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000803")]
		public Guid messageId; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60018C7")]
		public <>c__DisplayClass12_0() { }

		[Address(RVA = "0x3094CA0", Offset = "0x30940A0", Length = "0x58")]
		[Token(Token = "0x60018C8")]
		internal bool <Register>b__0(MessageTypeSubscribers x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200030A")]
	private sealed class <>c__DisplayClass13_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000804")]
		public Guid messageId; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60018C9")]
		public <>c__DisplayClass13_0() { }

		[Address(RVA = "0x3094CA0", Offset = "0x30940A0", Length = "0x58")]
		[Token(Token = "0x60018CA")]
		internal bool <Unregister>b__0(MessageTypeSubscribers x) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200030B")]
	private sealed class <>c__DisplayClass20_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000805")]
		public bool msgReceived; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60018CB")]
		public <>c__DisplayClass20_0() { }

		[Address(RVA = "0xE0B640", Offset = "0xE0AA40", Length = "0x5")]
		[Token(Token = "0x60018CC")]
		internal void <BlockUntilRecvMsg>b__0(MessageEventArgs args) { }

	}

	[Token(Token = "0x40007FE")]
	internal static IPlayerEditorConnectionNative connectionNative; //Field offset: 0x0
	[Token(Token = "0x4000802")]
	private static PlayerConnection s_Instance; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40007FF")]
	private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000800")]
	private List<Int32> m_connectedPlayers; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000801")]
	private bool m_IsInitilized; //Field offset: 0x28

	[Token(Token = "0x1700039B")]
	public static PlayerConnection instance
	{
		[Address(RVA = "0x3080570", Offset = "0x307F970", Length = "0x10B")]
		[Token(Token = "0x60018B4")]
		 get { } //Length: 267
	}

	[Token(Token = "0x1700039C")]
	public bool isConnected
	{
		[Address(RVA = "0x3080680", Offset = "0x307FA80", Length = "0x9C")]
		[Token(Token = "0x60018B5")]
		 get { } //Length: 156
	}

	[Address(RVA = "0x30803C0", Offset = "0x307F7C0", Length = "0x1AC")]
	[Token(Token = "0x60018C6")]
	public PlayerConnection() { }

	[Address(RVA = "0x307EF60", Offset = "0x307E360", Length = "0x2C1")]
	[Token(Token = "0x60018C1")]
	public bool BlockUntilRecvMsg(Guid messageId, int timeout) { }

	[Address(RVA = "0x307F230", Offset = "0x307E630", Length = "0xCB")]
	[RequiredByNativeCode]
	[Token(Token = "0x60018C4")]
	private static void ConnectedCallbackInternal(int playerId) { }

	[Address(RVA = "0x307F300", Offset = "0x307E700", Length = "0xA4")]
	[Token(Token = "0x60018B6")]
	private static PlayerConnection CreateInstance() { }

	[Address(RVA = "0x307F3B0", Offset = "0x307E7B0", Length = "0x9C")]
	[Token(Token = "0x60018C2")]
	public override void DisconnectAll() { }

	[Address(RVA = "0x307F450", Offset = "0x307E850", Length = "0x89")]
	[RequiredByNativeCode]
	[Token(Token = "0x60018C5")]
	private static void DisconnectedCallback(int playerId) { }

	[Address(RVA = "0x3080570", Offset = "0x307F970", Length = "0x10B")]
	[Token(Token = "0x60018B4")]
	public static PlayerConnection get_instance() { }

	[Address(RVA = "0x3080680", Offset = "0x307FA80", Length = "0x9C")]
	[Token(Token = "0x60018B5")]
	public bool get_isConnected() { }

	[Address(RVA = "0x307F4E0", Offset = "0x307E8E0", Length = "0x6D")]
	[Token(Token = "0x60018B8")]
	private IPlayerEditorConnectionNative GetConnectionNativeApi() { }

	[Address(RVA = "0x307F550", Offset = "0x307E950", Length = "0x26D")]
	[RequiredByNativeCode]
	[Token(Token = "0x60018C3")]
	private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId) { }

	[Address(RVA = "0x307F7C0", Offset = "0x307EBC0", Length = "0x5F")]
	[Token(Token = "0x60018B7")]
	public void OnEnable() { }

	[Address(RVA = "0x307F9F0", Offset = "0x307EDF0", Length = "0x296")]
	[Token(Token = "0x60018B9")]
	public override void Register(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	[Address(RVA = "0x307F820", Offset = "0x307EC20", Length = "0x16D")]
	[Token(Token = "0x60018BB")]
	public override void RegisterConnection(UnityAction<Int32> callback) { }

	[Address(RVA = "0x307F990", Offset = "0x307ED90", Length = "0x5C")]
	[Token(Token = "0x60018BC")]
	public override void RegisterDisconnection(UnityAction<Int32> callback) { }

	[Address(RVA = "0x307FC90", Offset = "0x307F090", Length = "0x1CD")]
	[Token(Token = "0x60018BF")]
	public override void Send(Guid messageId, Byte[] data) { }

	[Address(RVA = "0x307FE60", Offset = "0x307F260", Length = "0x1CD")]
	[Token(Token = "0x60018C0")]
	public override bool TrySend(Guid messageId, Byte[] data) { }

	[Address(RVA = "0x30800F0", Offset = "0x307F4F0", Length = "0x2C2")]
	[Token(Token = "0x60018BA")]
	public override void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	[Address(RVA = "0x3080030", Offset = "0x307F430", Length = "0x5C")]
	[Token(Token = "0x60018BD")]
	public override void UnregisterConnection(UnityAction<Int32> callback) { }

	[Address(RVA = "0x3080090", Offset = "0x307F490", Length = "0x5C")]
	[Token(Token = "0x60018BE")]
	public override void UnregisterDisconnection(UnityAction<Int32> callback) { }

}

