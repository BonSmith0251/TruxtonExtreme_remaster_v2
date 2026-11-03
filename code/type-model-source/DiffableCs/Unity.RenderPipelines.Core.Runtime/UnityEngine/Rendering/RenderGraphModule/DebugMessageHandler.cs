namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x2000239")]
internal class DebugMessageHandler : ScriptableObject
{
	[Token(Token = "0x200023D")]
	internal class AnalyticsPayload : IPayload
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40009FE")]
		public GraphicsDeviceType graphicsDeviceType; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40009FF")]
		public DeviceType deviceType; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A00")]
		public string deviceModel; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000A01")]
		public string gpuVendor; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000A02")]
		public string gpuName; //Field offset: 0x30

		[Address(RVA = "0x2C6E960", Offset = "0x2C6DD60", Length = "0x6E")]
		[Token(Token = "0x6000FEA")]
		public AnalyticsPayload() { }

	}

	[Token(Token = "0x200023C")]
	internal class DebugDataPayload : IPayload
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40009FB")]
		public string graphName; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40009FC")]
		public EntityId executionId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40009FD")]
		public DebugData debugData; //Field offset: 0x28

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000FE9")]
		public DebugDataPayload() { }

	}

	[Token(Token = "0x200023B")]
	internal abstract class IPayload
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009FA")]
		public int version; //Field offset: 0x10

		[Token(Token = "0x17000212")]
		public bool isCompatible
		{
			[Address(RVA = "0xF54050", Offset = "0xF53450", Length = "0x8")]
			[Token(Token = "0x6000FE7")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000FE8")]
		protected IPayload() { }

		[Address(RVA = "0xF54050", Offset = "0xF53450", Length = "0x8")]
		[Token(Token = "0x6000FE7")]
		public bool get_isCompatible() { }

	}

	[Token(Token = "0x200023A")]
	internal enum MessageType : byte
	{
		Activate = 0,
		DebugData = 1,
		AnalyticsData = 2,
	}

	[Token(Token = "0x40009F2")]
	internal const int k_Version = 1; //Field offset: 0x0
	[Token(Token = "0x40009F3")]
	private static readonly Guid s_EditorToPlayerGuid; //Field offset: 0x0
	[Token(Token = "0x40009F4")]
	private static readonly Guid s_PlayerToEditorGuid; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009F5")]
	private Action<MessageType, IPayload> m_UserCallback; //Field offset: 0x18

	[Address(RVA = "0x2C715B0", Offset = "0x2C709B0", Length = "0xA2")]
	[Token(Token = "0x6000FE6")]
	private static DebugMessageHandler() { }

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x6000FE5")]
	public DebugMessageHandler() { }

	[Address(RVA = "0x2C706C0", Offset = "0x2C6FAC0", Length = "0x6C1")]
	[Token(Token = "0x6000FE4")]
	internal static ValueTuple<MessageType, IPayload> DeserializeMessage(Byte[] data) { }

	[Address(RVA = "0x2C70D90", Offset = "0x2C70190", Length = "0x96")]
	[Token(Token = "0x6000FDF")]
	private void InternalCallback(MessageEventArgs msg) { }

	[Address(RVA = "0x2C70E30", Offset = "0x2C70230", Length = "0xEA")]
	[Token(Token = "0x6000FE0")]
	public void Register(Action<MessageType, IPayload> callback) { }

	[Address(RVA = "0x2C70F20", Offset = "0x2C70320", Length = "0xAE")]
	[Token(Token = "0x6000FE2")]
	public void Send(MessageType messageType, IPayload payload = null) { }

	[Address(RVA = "0x2C70FD0", Offset = "0x2C703D0", Length = "0x4F8")]
	[Token(Token = "0x6000FE3")]
	internal static Byte[] SerializeMessage(MessageType type, IPayload payload = null) { }

	[Address(RVA = "0x2C714D0", Offset = "0x2C708D0", Length = "0xD7")]
	[Token(Token = "0x6000FE1")]
	public void UnregisterAll() { }

}

