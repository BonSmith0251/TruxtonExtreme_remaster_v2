namespace UnityEngine.Events;

[Token(Token = "0x2000240")]
[UsedByNativeCode]
public abstract class UnityEventBase : ISerializationCallbackReceiver
{
	[Token(Token = "0x40007A8")]
	private static readonly List<WeakReference`1<UnityEventBase>> s_UnityEvents; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007A9")]
	private InvokableCallList m_Calls; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("m_PersistentListeners")]
	[SerializeField]
	[Token(Token = "0x40007AA")]
	private PersistentCallGroup m_PersistentCalls; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007AB")]
	private bool m_CallsDirty; //Field offset: 0x20

	[Address(RVA = "0x30969E0", Offset = "0x3095DE0", Length = "0x84")]
	[Token(Token = "0x6001803")]
	private static UnityEventBase() { }

	[Address(RVA = "0x3096A70", Offset = "0x3095E70", Length = "0x1B5")]
	[Token(Token = "0x60017F3")]
	protected UnityEventBase() { }

	[Address(RVA = "0x3095980", Offset = "0x3094D80", Length = "0xBD")]
	[Token(Token = "0x60017FD")]
	internal void AddCall(BaseInvokableCall call) { }

	[Address(RVA = "0x3095A40", Offset = "0x3094E40", Length = "0xD9")]
	[Token(Token = "0x60017FB")]
	private void DirtyPersistentCalls() { }

	[Address(RVA = "0x3095CF0", Offset = "0x30950F0", Length = "0x3A0")]
	[Token(Token = "0x60017F9")]
	internal MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType) { }

	[Address(RVA = "0x3095B20", Offset = "0x3094F20", Length = "0x1C7")]
	[Token(Token = "0x60017F8")]
	internal MethodInfo FindMethod(PersistentCall call) { }

	[Token(Token = "0x60017F6")]
	protected abstract MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	[Address(RVA = "0x30960B0", Offset = "0x30954B0", Length = "0x4E")]
	[Token(Token = "0x60017FA")]
	internal int GetCallsCount() { }

	[Token(Token = "0x60017F7")]
	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	[Address(RVA = "0x3096100", Offset = "0x3095500", Length = "0x1FB")]
	[Token(Token = "0x6001802")]
	public static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes) { }

	[Address(RVA = "0x3096300", Offset = "0x3095700", Length = "0x1D7")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	[Token(Token = "0x60017F2")]
	private static void OnPlayModeStateChange() { }

	[Address(RVA = "0x30964E0", Offset = "0x30958E0", Length = "0xD9")]
	[Token(Token = "0x6001800")]
	internal List<BaseInvokableCall> PrepareInvoke() { }

	[Address(RVA = "0x30965C0", Offset = "0x30959C0", Length = "0x36")]
	[Token(Token = "0x60017FC")]
	private void RebuildPersistentCallsIfNeeded() { }

	[Address(RVA = "0x3096600", Offset = "0x3095A00", Length = "0xC9")]
	[Token(Token = "0x60017FF")]
	public void RemoveAllListeners() { }

	[Address(RVA = "0x30966D0", Offset = "0x3095AD0", Length = "0x1E")]
	[Token(Token = "0x60017FE")]
	protected void RemoveListener(object targetObj, MethodInfo method) { }

	[Address(RVA = "0x30966F0", Offset = "0x3095AF0", Length = "0x80")]
	[Token(Token = "0x6001801")]
	public virtual string ToString() { }

	[Address(RVA = "0x3096780", Offset = "0x3095B80", Length = "0x12A")]
	[Token(Token = "0x60017F5")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[Address(RVA = "0x30968B0", Offset = "0x3095CB0", Length = "0x12A")]
	[Token(Token = "0x60017F4")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

