namespace UnityEngine.InputSystem;

[Token(Token = "0x2000098")]
public sealed class InputRemoting : IObservable<Message>, IObserver<Message>
{
	[Token(Token = "0x20000A9")]
	private static class ChangeUsageMsg
	{
		[CompilerGenerated]
		[Token(Token = "0x20000AB")]
		private sealed class <>c
		{
			[Token(Token = "0x4000430")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000431")]
			public static Func<InternedString, String> <>9__1_0; //Field offset: 0x8

			[Address(RVA = "0x29B41E0", Offset = "0x29B35E0", Length = "0x35F")]
			[Token(Token = "0x60009AF")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60009B0")]
			public <>c() { }

			[Address(RVA = "0x292B190", Offset = "0x292A590", Length = "0x13")]
			[Token(Token = "0x60009B1")]
			internal string <Create>b__1_0(InternedString x) { }

		}

		[Token(Token = "0x20000AA")]
		internal struct Data
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400042E")]
			public int deviceId; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x400042F")]
			public String[] usages; //Field offset: 0x8

		}


		[Address(RVA = "0x2993000", Offset = "0x2992400", Length = "0x1F1")]
		[Token(Token = "0x60009AD")]
		public static Message Create(InputDevice device) { }

		[Address(RVA = "0x2993200", Offset = "0x2992600", Length = "0x3AC")]
		[Token(Token = "0x60009AE")]
		public static void Process(InputRemoting receiver, Message msg) { }

	}

	[Token(Token = "0x200009F")]
	private static class ConnectMsg
	{

		[Address(RVA = "0x29935B0", Offset = "0x29929B0", Length = "0x47")]
		[Token(Token = "0x600099E")]
		public static void Process(InputRemoting receiver) { }

	}

	[Token(Token = "0x20000A2")]
	private static class DisconnectMsg
	{

		[Address(RVA = "0x2993610", Offset = "0x2992A10", Length = "0x1EE")]
		[Token(Token = "0x60009A1")]
		public static void Process(InputRemoting receiver, Message msg) { }

	}

	[Flags]
	[Token(Token = "0x200009B")]
	private enum Flags : int
	{
		Sending = 1,
		StartSendingOnConnect = 2,
	}

	[Token(Token = "0x200009A")]
	internal struct Message
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000416")]
		public int participantId; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000417")]
		public MessageType type; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000418")]
		public Byte[] data; //Field offset: 0x8

	}

	[Token(Token = "0x2000099")]
	internal enum MessageType : int
	{
		Connect = 0,
		Disconnect = 1,
		NewLayout = 2,
		NewDevice = 3,
		NewEvents = 4,
		RemoveDevice = 5,
		RemoveLayout = 6,
		ChangeUsages = 7,
		StartSending = 8,
		StopSending = 9,
	}

	[Token(Token = "0x20000A5")]
	private static class NewDeviceMsg
	{
		[CompilerGenerated]
		[Token(Token = "0x20000A7")]
		private sealed class <>c
		{
			[Token(Token = "0x400042C")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x400042D")]
			public static Func<InternedString, String> <>9__1_0; //Field offset: 0x8

			[Address(RVA = "0x29B4170", Offset = "0x29B3570", Length = "0x67")]
			[Token(Token = "0x60009A6")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60009A7")]
			public <>c() { }

			[Address(RVA = "0x292B190", Offset = "0x292A590", Length = "0x13")]
			[Token(Token = "0x60009A8")]
			internal string <Create>b__1_0(InternedString x) { }

		}

		[Token(Token = "0x20000A6")]
		internal struct Data
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000427")]
			public string name; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000428")]
			public string layout; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000429")]
			public int deviceId; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400042A")]
			public String[] usages; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400042B")]
			public InputDeviceDescription description; //Field offset: 0x20

		}


		[Address(RVA = "0x29AED10", Offset = "0x29AE110", Length = "0x2BF")]
		[Token(Token = "0x60009A4")]
		public static Message Create(InputDevice device) { }

		[Address(RVA = "0x29AEFD0", Offset = "0x29AE3D0", Length = "0x6AD")]
		[Token(Token = "0x60009A5")]
		public static void Process(InputRemoting receiver, Message msg) { }

	}

	[Token(Token = "0x20000A8")]
	private static class NewEventsMsg
	{

		[Address(RVA = "0x29AF800", Offset = "0x29AEC00", Length = "0xF4")]
		[Token(Token = "0x60009AB")]
		public static Message Create(InputEvent* events, int eventCount) { }

		[Address(RVA = "0x29AF680", Offset = "0x29AEA80", Length = "0x74")]
		[Token(Token = "0x60009A9")]
		public static Message CreateResetEvent(InputDevice device, bool isHardReset) { }

		[Address(RVA = "0x29AF700", Offset = "0x29AEB00", Length = "0xF7")]
		[Token(Token = "0x60009AA")]
		public static Message CreateStateEvent(InputDevice device) { }

		[Address(RVA = "0x29AF900", Offset = "0x29AED00", Length = "0x16D")]
		[Token(Token = "0x60009AC")]
		public static void Process(InputRemoting receiver, Message msg) { }

	}

	[Token(Token = "0x20000A3")]
	private static class NewLayoutMsg
	{
		[Token(Token = "0x20000A4")]
		internal struct Data
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000424")]
			public string name; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000425")]
			public string layoutJson; //Field offset: 0x8
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000426")]
			public bool isOverride; //Field offset: 0x10

		}


		[Address(RVA = "0x29AFA70", Offset = "0x29AEE70", Length = "0x2CD")]
		[Token(Token = "0x60009A2")]
		public static Nullable<Message> Create(InputRemoting sender, string layoutName) { }

		[Address(RVA = "0x29AFD40", Offset = "0x29AF140", Length = "0xF6")]
		[Token(Token = "0x60009A3")]
		public static void Process(InputRemoting receiver, Message msg) { }

	}

	[Token(Token = "0x200009D")]
	public struct RemoteInputDevice
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400041F")]
		public int remoteId; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000420")]
		public int localId; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000421")]
		public InputDeviceDescription description; //Field offset: 0x8

	}

	[Token(Token = "0x200009C")]
	public struct RemoteSender
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400041C")]
		public int senderId; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400041D")]
		public InternedString[] layouts; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400041E")]
		public RemoteInputDevice[] devices; //Field offset: 0x10

	}

	[Token(Token = "0x20000AC")]
	private static class RemoveDeviceMsg
	{

		[Address(RVA = "0x29B1DA0", Offset = "0x29B11A0", Length = "0x49")]
		[Token(Token = "0x60009B2")]
		public static Message Create(InputDevice device) { }

		[Address(RVA = "0x29B1DF0", Offset = "0x29B11F0", Length = "0x88")]
		[Token(Token = "0x60009B3")]
		public static void Process(InputRemoting receiver, Message msg) { }

	}

	[Token(Token = "0x20000A0")]
	private static class StartSendingMsg
	{

		[Address(RVA = "0x29B1FE0", Offset = "0x29B13E0", Length = "0x19")]
		[Token(Token = "0x600099F")]
		public static void Process(InputRemoting receiver) { }

	}

	[Token(Token = "0x20000A1")]
	private static class StopSendingMsg
	{

		[Address(RVA = "0x29B2200", Offset = "0x29B1600", Length = "0x19")]
		[Token(Token = "0x60009A0")]
		public static void Process(InputRemoting receiver) { }

	}

	[Token(Token = "0x200009E")]
	public class Subscriber : IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000422")]
		public InputRemoting owner; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000423")]
		public IObserver<Message> observer; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600099D")]
		public Subscriber() { }

		[Address(RVA = "0x29B2270", Offset = "0x29B1670", Length = "0x4B")]
		[Token(Token = "0x600099C")]
		public override void Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000407")]
	private Flags m_Flags; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000408")]
	private InputManager m_LocalManager; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000409")]
	private Subscriber[] m_Subscribers; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400040A")]
	private RemoteSender[] m_Senders; //Field offset: 0x28

	[Token(Token = "0x1700028B")]
	internal InputManager manager
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000998")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700028A")]
	public private bool sending
	{
		[Address(RVA = "0x1D63430", Offset = "0x1D62830", Length = "0x7")]
		[Token(Token = "0x6000982")]
		 get { } //Length: 7
		[Address(RVA = "0x29AAFF0", Offset = "0x29AA3F0", Length = "0x19")]
		[Token(Token = "0x6000983")]
		private set { } //Length: 25
	}

	[Address(RVA = "0x29AAF50", Offset = "0x29AA350", Length = "0x96")]
	[Token(Token = "0x6000984")]
	internal InputRemoting(InputManager manager, bool startSendingOnConnect = false) { }

	[Address(RVA = "0x29A9A60", Offset = "0x29A8E60", Length = "0x74")]
	[Token(Token = "0x6000995")]
	private static InternedString BuildLayoutNamespace(int senderId) { }

	[Address(RVA = "0x848040", Offset = "0x847440", Length = "0xD9")]
	[Token(Token = "0x600099B")]
	private static TData DeserializeData(Byte[] data) { }

	[Address(RVA = "0x29A9AE0", Offset = "0x29A8EE0", Length = "0x7A")]
	[Token(Token = "0x6000996")]
	private int FindLocalDeviceId(int remoteDeviceId, int senderIndex) { }

	[Address(RVA = "0x29A9B60", Offset = "0x29A8F60", Length = "0xBE")]
	[Token(Token = "0x6000994")]
	private int FindOrCreateSenderRecord(int senderId) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000998")]
	internal InputManager get_manager() { }

	[Address(RVA = "0x1D63430", Offset = "0x1D62830", Length = "0x7")]
	[Token(Token = "0x6000982")]
	public bool get_sending() { }

	[Address(RVA = "0x29A9C20", Offset = "0x29A9020", Length = "0x17F")]
	[Token(Token = "0x6000999")]
	public void RemoveRemoteDevices(int participantId) { }

	[Address(RVA = "0x29AA650", Offset = "0x29A9A50", Length = "0x128")]
	[Token(Token = "0x6000993")]
	private void Send(Message msg) { }

	[Address(RVA = "0x29A9DA0", Offset = "0x29A91A0", Length = "0x218")]
	[Token(Token = "0x600098E")]
	private void SendAllDevices() { }

	[Address(RVA = "0x29A9FC0", Offset = "0x29A93C0", Length = "0x21F")]
	[Token(Token = "0x600098C")]
	private void SendAllGeneratedLayouts() { }

	[Address(RVA = "0x29AA340", Offset = "0x29A9740", Length = "0x8A")]
	[Token(Token = "0x600098F")]
	private void SendDevice(InputDevice device) { }

	[Address(RVA = "0x29AA1E0", Offset = "0x29A95E0", Length = "0x152")]
	[Token(Token = "0x6000991")]
	private void SendDeviceChange(InputDevice device, InputDeviceChange change) { }

	[Address(RVA = "0x29AA3D0", Offset = "0x29A97D0", Length = "0x63")]
	[Token(Token = "0x6000990")]
	private void SendEvent(InputEventPtr eventPtr, InputDevice device) { }

	[Address(RVA = "0x29AA440", Offset = "0x29A9840", Length = "0x1F")]
	[Token(Token = "0x600098B")]
	private void SendInitialMessages() { }

	[Address(RVA = "0x29AA590", Offset = "0x29A9990", Length = "0xB7")]
	[Token(Token = "0x600098D")]
	private void SendLayout(string layoutName) { }

	[Address(RVA = "0x29AA460", Offset = "0x29A9860", Length = "0x129")]
	[Token(Token = "0x6000992")]
	private void SendLayoutChange(string layout, InputControlLayoutChange change) { }

	[Address(RVA = "0x8482F0", Offset = "0x8476F0", Length = "0xD5")]
	[Token(Token = "0x600099A")]
	private static Byte[] SerializeData(TData data) { }

	[Address(RVA = "0x29AAFF0", Offset = "0x29AA3F0", Length = "0x19")]
	[Token(Token = "0x6000983")]
	private void set_sending(bool value) { }

	[Address(RVA = "0x29AA780", Offset = "0x29A9B80", Length = "0x1C7")]
	[Token(Token = "0x6000985")]
	public void StartSending() { }

	[Address(RVA = "0x29AA950", Offset = "0x29A9D50", Length = "0x1B3")]
	[Token(Token = "0x6000986")]
	public void StopSending() { }

	[Address(RVA = "0x29AAB10", Offset = "0x29A9F10", Length = "0xF8")]
	[Token(Token = "0x600098A")]
	public override IDisposable Subscribe(IObserver<Message> observer) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000989")]
	private override void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000988")]
	private override void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(Exception error) { }

	[Address(RVA = "0x29AAC10", Offset = "0x29AA010", Length = "0x2E4")]
	[Token(Token = "0x6000987")]
	private override void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(Message msg) { }

	[Address(RVA = "0x29AAF20", Offset = "0x29AA320", Length = "0x2E")]
	[Token(Token = "0x6000997")]
	private InputDevice TryGetDeviceByRemoteId(int remoteDeviceId, int senderIndex) { }

}

