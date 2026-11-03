namespace UnityEngine;

[ExtensionOfNativeClass]
[NativeHeader("Runtime/Scripting/DelayedCallUtility.h")]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[RequiredByNativeCode]
[Token(Token = "0x20001B6")]
public class MonoBehaviour : Behaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000680")]
	private CancellationTokenSource m_CancellationTokenSource; //Field offset: 0x18

	[Token(Token = "0x170002F0")]
	public CancellationToken destroyCancellationToken
	{
		[Address(RVA = "0x3067BF0", Offset = "0x3066FF0", Length = "0x1AC")]
		[Token(Token = "0x60013B8")]
		 get { } //Length: 428
	}

	[Token(Token = "0x170002F3")]
	public bool didAwake
	{
		[Address(RVA = "0x3067DE0", Offset = "0x30671E0", Length = "0x76")]
		[Token(Token = "0x60013CB")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170002F2")]
	public bool didStart
	{
		[Address(RVA = "0x3067EA0", Offset = "0x30672A0", Length = "0x76")]
		[Token(Token = "0x60013CA")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170002F1")]
	public bool useGUILayout
	{
		[Address(RVA = "0x3067F60", Offset = "0x3067360", Length = "0x76")]
		[Token(Token = "0x60013C8")]
		 get { } //Length: 118
		[Address(RVA = "0x3068080", Offset = "0x3067480", Length = "0x86")]
		[Token(Token = "0x60013C9")]
		 set { } //Length: 134
	}

	[Address(RVA = "0x3057F90", Offset = "0x3057390", Length = "0x49")]
	[Token(Token = "0x60013D9")]
	public MonoBehaviour() { }

	[Address(RVA = "0x3065FA0", Offset = "0x30653A0", Length = "0x9B")]
	[Token(Token = "0x60013BB")]
	public void CancelInvoke() { }

	[Address(RVA = "0x3066050", Offset = "0x3065450", Length = "0x1F1")]
	[FreeFunction]
	[Token(Token = "0x60013D0")]
	private static void CancelInvoke(MonoBehaviour self, string methodName) { }

	[Address(RVA = "0x3066040", Offset = "0x3065440", Length = "0x8")]
	[Token(Token = "0x60013BE")]
	public void CancelInvoke(string methodName) { }

	[Address(RVA = "0x3065F50", Offset = "0x3065350", Length = "0x42")]
	[Token(Token = "0x60013E3")]
	private static void CancelInvoke_Injected(IntPtr self, ref ManagedSpanWrapper methodName) { }

	[Address(RVA = "0x3067BF0", Offset = "0x3066FF0", Length = "0x1AC")]
	[Token(Token = "0x60013B8")]
	public CancellationToken get_destroyCancellationToken() { }

	[Address(RVA = "0x3067DE0", Offset = "0x30671E0", Length = "0x76")]
	[Token(Token = "0x60013CB")]
	public bool get_didAwake() { }

	[Address(RVA = "0x3067DA0", Offset = "0x30671A0", Length = "0x33")]
	[Token(Token = "0x60013DF")]
	private static bool get_didAwake_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3067EA0", Offset = "0x30672A0", Length = "0x76")]
	[Token(Token = "0x60013CA")]
	public bool get_didStart() { }

	[Address(RVA = "0x3067E60", Offset = "0x3067260", Length = "0x33")]
	[Token(Token = "0x60013DE")]
	private static bool get_didStart_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3067F60", Offset = "0x3067360", Length = "0x76")]
	[Token(Token = "0x60013C8")]
	public bool get_useGUILayout() { }

	[Address(RVA = "0x3067F20", Offset = "0x3067320", Length = "0x33")]
	[Token(Token = "0x60013DC")]
	private static bool get_useGUILayout_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30662A0", Offset = "0x30656A0", Length = "0x106")]
	[Token(Token = "0x60013D7")]
	internal string GetScriptClassName() { }

	[Address(RVA = "0x3066250", Offset = "0x3065650", Length = "0x42")]
	[Token(Token = "0x60013EA")]
	private static void GetScriptClassName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x3065FA0", Offset = "0x30653A0", Length = "0x9B")]
	[FreeFunction("CancelInvoke")]
	[Token(Token = "0x60013CD")]
	private static void Internal_CancelInvokeAll(MonoBehaviour self) { }

	[Address(RVA = "0x30663B0", Offset = "0x30657B0", Length = "0x33")]
	[Token(Token = "0x60013E0")]
	private static void Internal_CancelInvokeAll_Injected(IntPtr self) { }

	[Address(RVA = "0x3066430", Offset = "0x3065830", Length = "0x9B")]
	[FreeFunction("IsInvoking")]
	[Token(Token = "0x60013CE")]
	private static bool Internal_IsInvokingAll(MonoBehaviour self) { }

	[Address(RVA = "0x30663F0", Offset = "0x30657F0", Length = "0x33")]
	[Token(Token = "0x60013E1")]
	private static bool Internal_IsInvokingAll_Injected(IntPtr self) { }

	[Address(RVA = "0x30667E0", Offset = "0x3065BE0", Length = "0x1A")]
	[Token(Token = "0x60013BC")]
	public void Invoke(string methodName, float time) { }

	[Address(RVA = "0x3066540", Offset = "0x3065940", Length = "0x215")]
	[FreeFunction]
	[Token(Token = "0x60013CF")]
	private static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) { }

	[Address(RVA = "0x30664D0", Offset = "0x30658D0", Length = "0x62")]
	[Token(Token = "0x60013E2")]
	private static void InvokeDelayed_Injected(IntPtr self, ref ManagedSpanWrapper methodName, float time, float repeatRate) { }

	[Address(RVA = "0x3066760", Offset = "0x3065B60", Length = "0x7F")]
	[Token(Token = "0x60013BD")]
	public void InvokeRepeating(string methodName, float time, float repeatRate) { }

	[Address(RVA = "0x3066850", Offset = "0x3065C50", Length = "0x1F8")]
	[FreeFunction]
	[Token(Token = "0x60013D1")]
	private static bool IsInvoking(MonoBehaviour self, string methodName) { }

	[Address(RVA = "0x3066430", Offset = "0x3065830", Length = "0x9B")]
	[Token(Token = "0x60013BA")]
	public bool IsInvoking() { }

	[Address(RVA = "0x3066A50", Offset = "0x3065E50", Length = "0xA")]
	[Token(Token = "0x60013BF")]
	public bool IsInvoking(string methodName) { }

	[Address(RVA = "0x3066800", Offset = "0x3065C00", Length = "0x42")]
	[Token(Token = "0x60013E4")]
	private static bool IsInvoking_Injected(IntPtr self, ref ManagedSpanWrapper methodName) { }

	[Address(RVA = "0x3066AA0", Offset = "0x3065EA0", Length = "0x9B")]
	[FreeFunction]
	[Token(Token = "0x60013D2")]
	private static bool IsObjectMonoBehaviour(object obj) { }

	[Address(RVA = "0x3066A60", Offset = "0x3065E60", Length = "0x33")]
	[Token(Token = "0x60013E5")]
	private static bool IsObjectMonoBehaviour_Injected(IntPtr obj) { }

	[Address(RVA = "0x3066B80", Offset = "0x3065F80", Length = "0x76")]
	[Token(Token = "0x60013D8")]
	private void OnCancellationTokenCreated() { }

	[Address(RVA = "0x3066B40", Offset = "0x3065F40", Length = "0x33")]
	[Token(Token = "0x60013EB")]
	private static void OnCancellationTokenCreated_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3067FE0", Offset = "0x30673E0", Length = "0x49")]
	[Token(Token = "0x60013CC")]
	public static void print(object message) { }

	[Address(RVA = "0x3066C00", Offset = "0x3066000", Length = "0x11")]
	[RequiredByNativeCode]
	[Token(Token = "0x60013B9")]
	private void RaiseCancellation() { }

	[Address(RVA = "0x3068080", Offset = "0x3067480", Length = "0x86")]
	[Token(Token = "0x60013C9")]
	public void set_useGUILayout(bool value) { }

	[Address(RVA = "0x3068030", Offset = "0x3067430", Length = "0x42")]
	[Token(Token = "0x60013DD")]
	private static void set_useGUILayout_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x30670F0", Offset = "0x30664F0", Length = "0x162")]
	[ExcludeFromDocs]
	[Token(Token = "0x60013C0")]
	public Coroutine StartCoroutine(string methodName) { }

	[Address(RVA = "0x3066F40", Offset = "0x3066340", Length = "0x1A4")]
	[Token(Token = "0x60013C2")]
	public Coroutine StartCoroutine(IEnumerator routine) { }

	[Address(RVA = "0x3067260", Offset = "0x3066660", Length = "0x173")]
	[Token(Token = "0x60013C1")]
	public Coroutine StartCoroutine(string methodName, object value) { }

	[Address(RVA = "0x3066F40", Offset = "0x3066340", Length = "0x1A4")]
	[Obsolete("StartCoroutine_Auto has been deprecated. Use StartCoroutine instead (UnityUpgradable) -> StartCoroutine([mscorlib] System.Collections.IEnumerator)", False)]
	[Token(Token = "0x60013C3")]
	public Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	[Address(RVA = "0x3066D60", Offset = "0x3066160", Length = "0x1D8")]
	[Token(Token = "0x60013D3")]
	private Coroutine StartCoroutineManaged(string methodName, object value) { }

	[Address(RVA = "0x3066D00", Offset = "0x3066100", Length = "0x52")]
	[Token(Token = "0x60013E6")]
	private static Coroutine StartCoroutineManaged_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, object value) { }

	[Address(RVA = "0x3066C70", Offset = "0x3066070", Length = "0x85")]
	[Token(Token = "0x60013D4")]
	private Coroutine StartCoroutineManaged2(IEnumerator enumerator) { }

	[Address(RVA = "0x3066C20", Offset = "0x3066020", Length = "0x42")]
	[Token(Token = "0x60013E7")]
	private static Coroutine StartCoroutineManaged2_Injected(IntPtr _unity_self, IEnumerator enumerator) { }

	[Address(RVA = "0x3067420", Offset = "0x3066820", Length = "0x76")]
	[Token(Token = "0x60013C7")]
	public void StopAllCoroutines() { }

	[Address(RVA = "0x30673E0", Offset = "0x30667E0", Length = "0x33")]
	[Token(Token = "0x60013DB")]
	private static void StopAllCoroutines_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3067890", Offset = "0x3066C90", Length = "0x1A8")]
	[Token(Token = "0x60013C5")]
	public void StopCoroutine(Coroutine routine) { }

	[Address(RVA = "0x30676C0", Offset = "0x3066AC0", Length = "0x1C7")]
	[Token(Token = "0x60013C6")]
	public void StopCoroutine(string methodName) { }

	[Address(RVA = "0x3067A40", Offset = "0x3066E40", Length = "0x1A4")]
	[Token(Token = "0x60013C4")]
	public void StopCoroutine(IEnumerator routine) { }

	[Address(RVA = "0x3067670", Offset = "0x3066A70", Length = "0x42")]
	[Token(Token = "0x60013DA")]
	private static void StopCoroutine_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName) { }

	[Address(RVA = "0x30674F0", Offset = "0x30668F0", Length = "0x85")]
	[Token(Token = "0x60013D6")]
	private void StopCoroutineFromEnumeratorManaged(IEnumerator routine) { }

	[Address(RVA = "0x30674A0", Offset = "0x30668A0", Length = "0x42")]
	[Token(Token = "0x60013E9")]
	private static void StopCoroutineFromEnumeratorManaged_Injected(IntPtr _unity_self, IEnumerator routine) { }

	[Address(RVA = "0x30675D0", Offset = "0x30669D0", Length = "0x9C")]
	[Token(Token = "0x60013D5")]
	private void StopCoroutineManaged(Coroutine routine) { }

	[Address(RVA = "0x3067580", Offset = "0x3066980", Length = "0x42")]
	[Token(Token = "0x60013E8")]
	private static void StopCoroutineManaged_Injected(IntPtr _unity_self, IntPtr routine) { }

}

