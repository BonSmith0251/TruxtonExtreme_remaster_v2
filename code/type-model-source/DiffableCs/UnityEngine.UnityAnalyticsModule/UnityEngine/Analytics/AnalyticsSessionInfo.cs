namespace UnityEngine.Analytics;

[NativeHeader("UnityAnalyticsScriptingClasses.h")]
[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000009")]
public static class AnalyticsSessionInfo
{
	[Token(Token = "0x200000B")]
	internal sealed class IdentityTokenChanged : MulticastDelegate
	{

		[Address(RVA = "0x1FCA570", Offset = "0x1FC9970", Length = "0xB4")]
		[Token(Token = "0x600000B")]
		public IdentityTokenChanged(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x600000C")]
		public override void Invoke(string token) { }

	}

	[Token(Token = "0x200000A")]
	internal sealed class SessionStateChanged : MulticastDelegate
	{

		[Address(RVA = "0x3479A30", Offset = "0x3478E30", Length = "0xA6")]
		[Token(Token = "0x6000009")]
		public SessionStateChanged(object object, IntPtr method) { }

		[Address(RVA = "0x1C4CE30", Offset = "0x1C4C230", Length = "0x1D")]
		[Token(Token = "0x600000A")]
		public override void Invoke(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000017")]
	private static SessionStateChanged sessionStateChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000018")]
	private static IdentityTokenChanged identityTokenChanged; //Field offset: 0x8

	[Address(RVA = "0x34797F0", Offset = "0x3478BF0", Length = "0x59")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000008")]
	internal static void CallIdentityTokenChanged(string token) { }

	[Address(RVA = "0x3479850", Offset = "0x3478C50", Length = "0x87")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000007")]
	internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged) { }

}

