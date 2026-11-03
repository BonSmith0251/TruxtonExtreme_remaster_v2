namespace UnityEngine.Playables;

[NativeHeader("Runtime/Export/Director/PlayableOutputHandle.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[Token(Token = "0x200032A")]
[UsedByNativeCode]
public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle>
{
	[Token(Token = "0x400084B")]
	private static readonly PlayableOutputHandle m_Null; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000849")]
	internal IntPtr m_Handle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400084A")]
	internal uint m_Version; //Field offset: 0x8

	[Token(Token = "0x170003B3")]
	public static PlayableOutputHandle Null
	{
		[Address(RVA = "0x307E960", Offset = "0x307DD60", Length = "0x60")]
		[Token(Token = "0x6001997")]
		 get { } //Length: 96
	}

	[Address(RVA = "0x307E920", Offset = "0x307DD20", Length = "0x39")]
	[Token(Token = "0x60019A9")]
	private static PlayableOutputHandle() { }

	[Address(RVA = "0x307E150", Offset = "0x307D550", Length = "0x42")]
	[FreeFunction("PlayableOutputHandleBindings::AddNotificationReceiver", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x60019A8")]
	internal void AddNotificationReceiver(INotificationReceiver receiver) { }

	[Address(RVA = "0xD15EB0", Offset = "0xD152B0", Length = "0x1C")]
	[Token(Token = "0x600199D")]
	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	[Address(RVA = "0x307E1A0", Offset = "0x307D5A0", Length = "0x10F")]
	[Token(Token = "0x600199B")]
	public virtual bool Equals(object p) { }

	[Address(RVA = "0x307E2B0", Offset = "0x307D6B0", Length = "0x82")]
	[Token(Token = "0x600199C")]
	public override bool Equals(PlayableOutputHandle other) { }

	[Address(RVA = "0x307E960", Offset = "0x307DD60", Length = "0x60")]
	[Token(Token = "0x6001997")]
	public static PlayableOutputHandle get_Null() { }

	[Address(RVA = "0x307D400", Offset = "0x307C800", Length = "0x2E")]
	[Token(Token = "0x6001999")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x307E340", Offset = "0x307D740", Length = "0x33")]
	[FreeFunction("PlayableOutputHandleBindings::GetPlayableOutputType", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600199F")]
	internal Type GetPlayableOutputType() { }

	[Address(RVA = "0x307E380", Offset = "0x307D780", Length = "0x33")]
	[FreeFunction("PlayableOutputHandleBindings::GetSourceOutputPort", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x60019A5")]
	internal int GetSourceOutputPort() { }

	[Address(RVA = "0x307E410", Offset = "0x307D810", Length = "0x7C")]
	[FreeFunction("PlayableOutputHandleBindings::GetSourcePlayable", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x60019A3")]
	internal PlayableHandle GetSourcePlayable() { }

	[Address(RVA = "0x307E3C0", Offset = "0x307D7C0", Length = "0x42")]
	[Token(Token = "0x60019AC")]
	private static void GetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, out PlayableHandle ret) { }

	[Address(RVA = "0x307E4D0", Offset = "0x307D8D0", Length = "0x7E")]
	[FreeFunction("PlayableOutputHandleBindings::GetUserData", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x60019A1")]
	internal object GetUserData() { }

	[Address(RVA = "0x307E490", Offset = "0x307D890", Length = "0x33")]
	[Token(Token = "0x60019AB")]
	private static IntPtr GetUserData_Injected(ref PlayableOutputHandle _unity_self) { }

	[Address(RVA = "0x8B1410", Offset = "0x8B0810", Length = "0x92")]
	[Token(Token = "0x6001998")]
	[VisibleToOtherModules]
	internal bool IsPlayableOutputOfType() { }

	[Address(RVA = "0x307E550", Offset = "0x307D950", Length = "0x33")]
	[Token(Token = "0x600199E")]
	[VisibleToOtherModules]
	internal bool IsValid() { }

	[Address(RVA = "0x307E9C0", Offset = "0x307DDC0", Length = "0x6D")]
	[Token(Token = "0x600199A")]
	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	[Address(RVA = "0x307E600", Offset = "0x307DA00", Length = "0x93")]
	[FreeFunction("PlayableOutputHandleBindings::PushNotification", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x60019A7")]
	internal void PushNotification(PlayableHandle origin, INotification notification, object context) { }

	[Address(RVA = "0x307E590", Offset = "0x307D990", Length = "0x62")]
	[Token(Token = "0x60019AE")]
	private static void PushNotification_Injected(ref PlayableOutputHandle _unity_self, in PlayableHandle origin, INotification notification, object context) { }

	[Address(RVA = "0x307E6F0", Offset = "0x307DAF0", Length = "0x9B")]
	[FreeFunction("PlayableOutputHandleBindings::SetReferenceObject", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x60019A0")]
	internal void SetReferenceObject(object target) { }

	[Address(RVA = "0x307E6A0", Offset = "0x307DAA0", Length = "0x42")]
	[Token(Token = "0x60019AA")]
	private static void SetReferenceObject_Injected(ref PlayableOutputHandle _unity_self, IntPtr target) { }

	[Address(RVA = "0x307E7F0", Offset = "0x307DBF0", Length = "0x83")]
	[FreeFunction("PlayableOutputHandleBindings::SetSourcePlayable", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x60019A4")]
	internal void SetSourcePlayable(PlayableHandle target, int port) { }

	[Address(RVA = "0x307E790", Offset = "0x307DB90", Length = "0x52")]
	[Token(Token = "0x60019AD")]
	private static void SetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, in PlayableHandle target, int port) { }

	[Address(RVA = "0x307E880", Offset = "0x307DC80", Length = "0x42")]
	[FreeFunction("PlayableOutputHandleBindings::SetUserData", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x60019A2")]
	internal void SetUserData(object target) { }

	[Address(RVA = "0x307E8D0", Offset = "0x307DCD0", Length = "0x43")]
	[FreeFunction("PlayableOutputHandleBindings::SetWeight", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x60019A6")]
	internal void SetWeight(float weight) { }

}

