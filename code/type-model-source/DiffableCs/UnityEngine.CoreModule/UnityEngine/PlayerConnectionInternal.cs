namespace UnityEngine;

[NativeHeader("Runtime/Export/PlayerConnection/PlayerConnectionInternal.bindings.h")]
[Token(Token = "0x2000165")]
internal class PlayerConnectionInternal : IPlayerEditorConnectionNative
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60011E0")]
	public PlayerConnectionInternal() { }

	[Address(RVA = "0x306D600", Offset = "0x306CA00", Length = "0x2A")]
	[FreeFunction("PlayerConnection_Bindings::DisconnectAll")]
	[Token(Token = "0x60011DF")]
	private static void DisconnectAll() { }

	[Address(RVA = "0x306D630", Offset = "0x306CA30", Length = "0x2A")]
	[FreeFunction("PlayerConnection_Bindings::Initialize")]
	[Token(Token = "0x60011D9")]
	private static void Initialize() { }

	[Address(RVA = "0x306D660", Offset = "0x306CA60", Length = "0x2A")]
	[FreeFunction("PlayerConnection_Bindings::IsConnected")]
	[Token(Token = "0x60011D8")]
	private static bool IsConnected() { }

	[Address(RVA = "0x306D690", Offset = "0x306CA90", Length = "0x2A")]
	[FreeFunction("PlayerConnection_Bindings::PollInternal")]
	[Token(Token = "0x60011DE")]
	private static void PollInternal() { }

	[Address(RVA = "0x306D700", Offset = "0x306CB00", Length = "0x178")]
	[FreeFunction("PlayerConnection_Bindings::RegisterInternal")]
	[Token(Token = "0x60011DA")]
	private static void RegisterInternal(string messageId) { }

	[Address(RVA = "0x306D6C0", Offset = "0x306CAC0", Length = "0x33")]
	[Token(Token = "0x60011E1")]
	private static void RegisterInternal_Injected(ref ManagedSpanWrapper messageId) { }

	[Address(RVA = "0x306D8E0", Offset = "0x306CCE0", Length = "0x246")]
	[FreeFunction("PlayerConnection_Bindings::SendMessage")]
	[Token(Token = "0x60011DC")]
	private static void SendMessage(string messageId, Byte[] data, int playerId) { }

	[Address(RVA = "0x306D880", Offset = "0x306CC80", Length = "0x52")]
	[Token(Token = "0x60011E3")]
	private static void SendMessage_Injected(ref ManagedSpanWrapper messageId, ref ManagedSpanWrapper data, int playerId) { }

	[Address(RVA = "0x306DB90", Offset = "0x306CF90", Length = "0x24C")]
	[FreeFunction("PlayerConnection_Bindings::TrySendMessage")]
	[Token(Token = "0x60011DD")]
	private static bool TrySendMessage(string messageId, Byte[] data, int playerId) { }

	[Address(RVA = "0x306DB30", Offset = "0x306CF30", Length = "0x52")]
	[Token(Token = "0x60011E4")]
	private static bool TrySendMessage_Injected(ref ManagedSpanWrapper messageId, ref ManagedSpanWrapper data, int playerId) { }

	[Address(RVA = "0x306D600", Offset = "0x306CA00", Length = "0x2A")]
	[Token(Token = "0x60011D7")]
	private override void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	[Address(RVA = "0x306D630", Offset = "0x306CA30", Length = "0x2A")]
	[Token(Token = "0x60011D5")]
	private override void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	[Address(RVA = "0x306D660", Offset = "0x306CA60", Length = "0x2A")]
	[Token(Token = "0x60011D6")]
	private override bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	[Address(RVA = "0x306D690", Offset = "0x306CA90", Length = "0x2A")]
	[Token(Token = "0x60011D2")]
	private override void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	[Address(RVA = "0x306DDE0", Offset = "0x306D1E0", Length = "0x47")]
	[Token(Token = "0x60011D3")]
	private override void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	[Address(RVA = "0x306DE30", Offset = "0x306D230", Length = "0xEF")]
	[Token(Token = "0x60011D0")]
	private override void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, Byte[] data, int playerId) { }

	[Address(RVA = "0x306DF20", Offset = "0x306D320", Length = "0xEF")]
	[Token(Token = "0x60011D1")]
	private override bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, Byte[] data, int playerId) { }

	[Address(RVA = "0x306E010", Offset = "0x306D410", Length = "0x47")]
	[Token(Token = "0x60011D4")]
	private override void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	[Address(RVA = "0x306E0A0", Offset = "0x306D4A0", Length = "0x178")]
	[FreeFunction("PlayerConnection_Bindings::UnregisterInternal")]
	[Token(Token = "0x60011DB")]
	private static void UnregisterInternal(string messageId) { }

	[Address(RVA = "0x306E060", Offset = "0x306D460", Length = "0x33")]
	[Token(Token = "0x60011E2")]
	private static void UnregisterInternal_Injected(ref ManagedSpanWrapper messageId) { }

}

