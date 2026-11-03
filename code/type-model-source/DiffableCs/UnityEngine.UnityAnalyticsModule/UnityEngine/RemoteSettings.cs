namespace UnityEngine;

[NativeHeader("UnityAnalyticsScriptingClasses.h")]
[NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
[Token(Token = "0x2000002")]
public static class RemoteSettings
{
	[Token(Token = "0x2000003")]
	internal sealed class UpdatedEventHandler : MulticastDelegate
	{

		[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
		[Token(Token = "0x6000004")]
		public UpdatedEventHandler(object object, IntPtr method) { }

		[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
		[Token(Token = "0x6000005")]
		public override void Invoke() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000001")]
	private static UpdatedEventHandler Updated; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000002")]
	private static Action BeforeFetchFromServer; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000003")]
	private static Action<Boolean, Boolean, Int32> Completed; //Field offset: 0x10

	[Address(RVA = "0x3479910", Offset = "0x3478D10", Length = "0x4F")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000002")]
	internal static void RemoteSettingsBeforeFetchFromServer() { }

	[Address(RVA = "0x3479960", Offset = "0x3478D60", Length = "0x7A")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000003")]
	internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response) { }

	[Address(RVA = "0x34799E0", Offset = "0x3478DE0", Length = "0x4E")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000001")]
	internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer) { }

}

