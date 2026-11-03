namespace UnityEngine.InputSystem.Utilities;

[Token(Token = "0x2000240")]
internal static class DelegateHelpers
{

	[Address(RVA = "0x290E2B0", Offset = "0x290D6B0", Length = "0x257")]
	[Token(Token = "0x600150F")]
	public static void InvokeCallbacksSafe(ref CallbackArray<Action>& callbacks, ProfilerMarker marker, string callbackName, object context = null) { }

	[Address(RVA = "0x7D0810", Offset = "0x7CFC10", Length = "0x245")]
	[Token(Token = "0x6001510")]
	public static void InvokeCallbacksSafe(ref CallbackArray<Action`1<TValue>>& callbacks, TValue argument, string callbackName, object context = null) { }

	[Address(RVA = "0x7D05B0", Offset = "0x7CF9B0", Length = "0x252")]
	[Token(Token = "0x6001511")]
	public static void InvokeCallbacksSafe(ref CallbackArray<Action`2<TValue1, TValue2>>& callbacks, TValue1 argument1, TValue2 argument2, ProfilerMarker marker, string callbackName, object context = null) { }

	[Address(RVA = "0x7CF0A0", Offset = "0x7CE4A0", Length = "0x2F9")]
	[Token(Token = "0x6001513")]
	public static void InvokeCallbacksSafe_AndInvokeReturnedActions(ref CallbackArray<Func`2<TValue, Action>>& callbacks, TValue argument, string callbackName, object context = null) { }

	[Address(RVA = "0x7CF3A0", Offset = "0x7CE7A0", Length = "0x344")]
	[Token(Token = "0x6001514")]
	public static bool InvokeCallbacksSafe_AnyCallbackReturnsObject(ref CallbackArray<Func`2<TValue, TReturn>>& callbacks, TValue argument, string callbackName, object context = null) { }

	[Address(RVA = "0x7CFA80", Offset = "0x7CEE80", Length = "0x27B")]
	[Token(Token = "0x6001512")]
	public static bool InvokeCallbacksSafe_AnyCallbackReturnsTrue(ref CallbackArray<Func`3<TValue1, TValue2, Boolean>>& callbacks, TValue1 argument1, TValue2 argument2, string callbackName, object context = null) { }

}

