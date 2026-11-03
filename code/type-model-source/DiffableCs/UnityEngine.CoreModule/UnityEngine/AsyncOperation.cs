namespace UnityEngine;

[NativeHeader("Runtime/Export/Scripting/AsyncOperation.bindings.h")]
[NativeHeader("Runtime/Misc/AsyncOperation.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000182")]
public class AsyncOperation : YieldInstruction
{
	[Token(Token = "0x2000183")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x3058240", Offset = "0x3057640", Length = "0x80")]
		[Token(Token = "0x6001277")]
		public static AsyncOperation ConvertToManaged(IntPtr ptr) { }

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6001278")]
		public static IntPtr ConvertToNative(AsyncOperation asyncOperation) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400061F")]
	[VisibleToOtherModules]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000620")]
	private Action<AsyncOperation> m_completeCallback; //Field offset: 0x18

	[Token(Token = "0x14000007")]
	public event Action<AsyncOperation> completed
	{
		[Address(RVA = "0x3054BC0", Offset = "0x3053FC0", Length = "0x123")]
		[Token(Token = "0x6001270")]
		 add { } //Length: 291
		[Address(RVA = "0x3054ED0", Offset = "0x30542D0", Length = "0xAF")]
		[Token(Token = "0x6001271")]
		 remove { } //Length: 175
	}

	[Token(Token = "0x170002C9")]
	public bool allowSceneActivation
	{
		[Address(RVA = "0x3054D30", Offset = "0x3054130", Length = "0x51")]
		[NativeMethod("GetAllowSceneActivation")]
		[Token(Token = "0x600126C")]
		 get { } //Length: 81
		[Address(RVA = "0x3054FD0", Offset = "0x30543D0", Length = "0x5B")]
		[NativeMethod("SetAllowSceneActivation")]
		[Token(Token = "0x600126D")]
		 set { } //Length: 91
	}

	[Token(Token = "0x170002C6")]
	public bool isDone
	{
		[Address(RVA = "0x3054DD0", Offset = "0x30541D0", Length = "0x51")]
		[NativeMethod("IsDone")]
		[Token(Token = "0x6001269")]
		 get { } //Length: 81
	}

	[Token(Token = "0x170002C8")]
	public int priority
	{
		[Address(RVA = "0x3055070", Offset = "0x3054470", Length = "0x58")]
		[NativeMethod("SetPriority")]
		[Token(Token = "0x600126B")]
		 set { } //Length: 88
	}

	[Token(Token = "0x170002C7")]
	public float progress
	{
		[Address(RVA = "0x3054E70", Offset = "0x3054270", Length = "0x51")]
		[NativeMethod("GetProgress")]
		[Token(Token = "0x600126A")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001267")]
	public AsyncOperation() { }

	[Address(RVA = "0x3054B60", Offset = "0x3053F60", Length = "0x52")]
	[Token(Token = "0x6001268")]
	protected AsyncOperation(IntPtr ptr) { }

	[Address(RVA = "0x3054BC0", Offset = "0x3053FC0", Length = "0x123")]
	[Token(Token = "0x6001270")]
	public void add_completed(Action<AsyncOperation> value) { }

	[Address(RVA = "0x3054A00", Offset = "0x3053E00", Length = "0x7A")]
	[Token(Token = "0x600126E")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x3054D30", Offset = "0x3054130", Length = "0x51")]
	[NativeMethod("GetAllowSceneActivation")]
	[Token(Token = "0x600126C")]
	public bool get_allowSceneActivation() { }

	[Address(RVA = "0x3054CF0", Offset = "0x30540F0", Length = "0x33")]
	[Token(Token = "0x6001275")]
	private static bool get_allowSceneActivation_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3054DD0", Offset = "0x30541D0", Length = "0x51")]
	[NativeMethod("IsDone")]
	[Token(Token = "0x6001269")]
	public bool get_isDone() { }

	[Address(RVA = "0x3054D90", Offset = "0x3054190", Length = "0x33")]
	[Token(Token = "0x6001272")]
	private static bool get_isDone_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3054E70", Offset = "0x3054270", Length = "0x51")]
	[NativeMethod("GetProgress")]
	[Token(Token = "0x600126A")]
	public float get_progress() { }

	[Address(RVA = "0x3054E30", Offset = "0x3054230", Length = "0x33")]
	[Token(Token = "0x6001273")]
	private static float get_progress_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3054A80", Offset = "0x3053E80", Length = "0x33")]
	[NativeMethod(IsThreadSafe = True)]
	[StaticAccessor("AsyncOperationBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6001265")]
	private static void InternalDestroy(IntPtr ptr) { }

	[Address(RVA = "0x3054AC0", Offset = "0x3053EC0", Length = "0x42")]
	[NativeMethod(IsThreadSafe = True)]
	[StaticAccessor("AsyncOperationBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6001266")]
	private static void InternalSetManagedObject(IntPtr ptr, AsyncOperation self) { }

	[Address(RVA = "0x3054B10", Offset = "0x3053F10", Length = "0x43")]
	[RequiredByNativeCode]
	[Token(Token = "0x600126F")]
	internal void InvokeCompletionEvent() { }

	[Address(RVA = "0x3054ED0", Offset = "0x30542D0", Length = "0xAF")]
	[Token(Token = "0x6001271")]
	public void remove_completed(Action<AsyncOperation> value) { }

	[Address(RVA = "0x3054FD0", Offset = "0x30543D0", Length = "0x5B")]
	[NativeMethod("SetAllowSceneActivation")]
	[Token(Token = "0x600126D")]
	public void set_allowSceneActivation(bool value) { }

	[Address(RVA = "0x3054F80", Offset = "0x3054380", Length = "0x42")]
	[Token(Token = "0x6001276")]
	private static void set_allowSceneActivation_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x3055070", Offset = "0x3054470", Length = "0x58")]
	[NativeMethod("SetPriority")]
	[Token(Token = "0x600126B")]
	public void set_priority(int value) { }

	[Address(RVA = "0x3055030", Offset = "0x3054430", Length = "0x40")]
	[Token(Token = "0x6001274")]
	private static void set_priority_Injected(IntPtr _unity_self, int value) { }

}

