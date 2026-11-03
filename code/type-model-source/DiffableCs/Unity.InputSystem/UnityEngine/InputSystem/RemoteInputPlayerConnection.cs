namespace UnityEngine.InputSystem;

[Token(Token = "0x20000AD")]
internal class RemoteInputPlayerConnection : ScriptableObject, IObserver<Message>, IObservable<Message>
{
	[Token(Token = "0x20000AE")]
	private class Subscriber : IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400043C")]
		public RemoteInputPlayerConnection owner; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400043D")]
		public IObserver<Message> observer; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60009C6")]
		public Subscriber() { }

		[Address(RVA = "0x29B2220", Offset = "0x29B1620", Length = "0x4B")]
		[Token(Token = "0x60009C5")]
		public override void Dispose() { }

	}

	[Token(Token = "0x4000432")]
	public static readonly Guid kNewDeviceMsg; //Field offset: 0x0
	[Token(Token = "0x4000433")]
	public static readonly Guid kNewLayoutMsg; //Field offset: 0x10
	[Token(Token = "0x4000434")]
	public static readonly Guid kNewEventsMsg; //Field offset: 0x20
	[Token(Token = "0x4000435")]
	public static readonly Guid kRemoveDeviceMsg; //Field offset: 0x30
	[Token(Token = "0x4000436")]
	public static readonly Guid kChangeUsagesMsg; //Field offset: 0x40
	[Token(Token = "0x4000437")]
	public static readonly Guid kStartSendingMsg; //Field offset: 0x50
	[Token(Token = "0x4000438")]
	public static readonly Guid kStopSendingMsg; //Field offset: 0x60
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000439")]
	private IEditorPlayerConnection m_Connection; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400043A")]
	private Subscriber[] m_Subscribers; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400043B")]
	private Int32[] m_ConnectedIds; //Field offset: 0x28

	[Address(RVA = "0x29B1BB0", Offset = "0x29B0FB0", Length = "0x1EC")]
	[Token(Token = "0x60009C4")]
	private static RemoteInputPlayerConnection() { }

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x60009C3")]
	public RemoteInputPlayerConnection() { }

	[Address(RVA = "0x29B0C20", Offset = "0x29B0020", Length = "0x7D2")]
	[Token(Token = "0x60009B4")]
	public void Bind(IEditorPlayerConnection connection, bool isConnected) { }

	[Address(RVA = "0x29B1400", Offset = "0x29B0800", Length = "0x10")]
	[Token(Token = "0x60009BC")]
	private void OnChangeUsages(MessageEventArgs args) { }

	[Address(RVA = "0x29B1410", Offset = "0x29B0810", Length = "0xBD")]
	[Token(Token = "0x60009B6")]
	private void OnConnected(int id) { }

	[Address(RVA = "0x29B14D0", Offset = "0x29B08D0", Length = "0xC0")]
	[Token(Token = "0x60009B7")]
	private void OnDisconnected(int id) { }

	[Address(RVA = "0x29B15A0", Offset = "0x29B09A0", Length = "0x10")]
	[Token(Token = "0x60009B8")]
	private void OnNewDevice(MessageEventArgs args) { }

	[Address(RVA = "0x29B15B0", Offset = "0x29B09B0", Length = "0x10")]
	[Token(Token = "0x60009BA")]
	private void OnNewEvents(MessageEventArgs args) { }

	[Address(RVA = "0x29B15C0", Offset = "0x29B09C0", Length = "0x10")]
	[Token(Token = "0x60009B9")]
	private void OnNewLayout(MessageEventArgs args) { }

	[Address(RVA = "0x29B15D0", Offset = "0x29B09D0", Length = "0x10")]
	[Token(Token = "0x60009BB")]
	private void OnRemoveDevice(MessageEventArgs args) { }

	[Address(RVA = "0x29B15E0", Offset = "0x29B09E0", Length = "0x10")]
	[Token(Token = "0x60009BD")]
	private void OnStartSending(MessageEventArgs args) { }

	[Address(RVA = "0x29B15F0", Offset = "0x29B09F0", Length = "0x10")]
	[Token(Token = "0x60009BE")]
	private void OnStopSending(MessageEventArgs args) { }

	[Address(RVA = "0x29B1600", Offset = "0x29B0A00", Length = "0x1C5")]
	[Token(Token = "0x60009BF")]
	private void SendToSubscribers(MessageType type, MessageEventArgs args) { }

	[Address(RVA = "0x29B17D0", Offset = "0x29B0BD0", Length = "0x206")]
	[Token(Token = "0x60009B5")]
	public override IDisposable Subscribe(IObserver<Message> observer) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60009C2")]
	private override void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60009C1")]
	private override void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error) { }

	[Address(RVA = "0x29B19E0", Offset = "0x29B0DE0", Length = "0x1B0")]
	[Token(Token = "0x60009C0")]
	private override void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(Message msg) { }

}

