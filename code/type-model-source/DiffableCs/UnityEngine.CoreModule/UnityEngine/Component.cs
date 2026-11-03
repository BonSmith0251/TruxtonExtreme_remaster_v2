namespace UnityEngine;

[NativeClass("Unity::Component")]
[NativeHeader("Runtime/Export/Scripting/Component.bindings.h")]
[RequiredByNativeCode]
[Token(Token = "0x20001A1")]
public class Component : object
{

	[Token(Token = "0x170002DB")]
	public GameObject gameObject
	{
		[Address(RVA = "0x30590A0", Offset = "0x30584A0", Length = "0x90")]
		[FreeFunction("GetGameObject", HasExplicitThis = True)]
		[Token(Token = "0x60012DB")]
		 get { } //Length: 144
	}

	[Token(Token = "0x170002DC")]
	public string tag
	{
		[Address(RVA = "0x3059220", Offset = "0x3058620", Length = "0xAF")]
		[Token(Token = "0x60012F1")]
		 set { } //Length: 175
	}

	[Token(Token = "0x170002DA")]
	public Transform transform
	{
		[Address(RVA = "0x3059180", Offset = "0x3058580", Length = "0x90")]
		[FreeFunction("GetTransform", HasExplicitThis = True, ThrowsException = True)]
		[Token(Token = "0x60012DA")]
		 get { } //Length: 144
	}

	[Address(RVA = "0x3057F90", Offset = "0x3057390", Length = "0x49")]
	[Token(Token = "0x60012F6")]
	public Component() { }

	[Address(RVA = "0x3058410", Offset = "0x3057810", Length = "0x1DB")]
	[FreeFunction("BroadcastMessage", HasExplicitThis = True)]
	[Token(Token = "0x60012F5")]
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	[Address(RVA = "0x30583A0", Offset = "0x30577A0", Length = "0x62")]
	[Token(Token = "0x60012FC")]
	private static void BroadcastMessage_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, object parameter, SendMessageOptions options) { }

	[Address(RVA = "0x30585F0", Offset = "0x30579F0", Length = "0xAF")]
	[Token(Token = "0x60012F3")]
	public bool CompareTag(string tag) { }

	[Address(RVA = "0x30590A0", Offset = "0x30584A0", Length = "0x90")]
	[FreeFunction("GetGameObject", HasExplicitThis = True)]
	[Token(Token = "0x60012DB")]
	public GameObject get_gameObject() { }

	[Address(RVA = "0x3059060", Offset = "0x3058460", Length = "0x33")]
	[Token(Token = "0x60012F8")]
	private static IntPtr get_gameObject_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3059180", Offset = "0x3058580", Length = "0x90")]
	[FreeFunction("GetTransform", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x60012DA")]
	public Transform get_transform() { }

	[Address(RVA = "0x3059140", Offset = "0x3058540", Length = "0x33")]
	[Token(Token = "0x60012F7")]
	private static IntPtr get_transform_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3058A00", Offset = "0x3057E00", Length = "0x11D")]
	[Token(Token = "0x60012DC")]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponent(Type type) { }

	[Address(RVA = "0x7A6630", Offset = "0x7A5A30", Length = "0x71")]
	[Token(Token = "0x60012DE")]
	public T GetComponent() { }

	[Address(RVA = "0x3058700", Offset = "0x3057B00", Length = "0x95")]
	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x60012DD")]
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[Address(RVA = "0x30586A0", Offset = "0x3057AA0", Length = "0x52")]
	[Token(Token = "0x60012F9")]
	private static void GetComponentFastPath_Injected(IntPtr _unity_self, Type type, IntPtr oneFurtherThanResultValue) { }

	[Address(RVA = "0x30587A0", Offset = "0x3057BA0", Length = "0x12F")]
	[Token(Token = "0x60012E1")]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	[Address(RVA = "0x7A5EF0", Offset = "0x7A52F0", Length = "0xBA")]
	[Token(Token = "0x60012E2")]
	public T GetComponentInChildren(bool includeInactive) { }

	[Address(RVA = "0x7A5FB0", Offset = "0x7A53B0", Length = "0xAC")]
	[ExcludeFromDocs]
	[Token(Token = "0x60012E3")]
	public T GetComponentInChildren() { }

	[Address(RVA = "0x30588D0", Offset = "0x3057CD0", Length = "0x12F")]
	[Token(Token = "0x60012E8")]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInParent(Type t, bool includeInactive) { }

	[Address(RVA = "0x7A62F0", Offset = "0x7A56F0", Length = "0xBA")]
	[Token(Token = "0x60012E9")]
	public T GetComponentInParent(bool includeInactive) { }

	[Address(RVA = "0x7A63B0", Offset = "0x7A57B0", Length = "0xAC")]
	[Token(Token = "0x60012EA")]
	public T GetComponentInParent() { }

	[Address(RVA = "0x7A6BF0", Offset = "0x7A5FF0", Length = "0x4C")]
	[Token(Token = "0x60012F2")]
	public T[] GetComponents() { }

	[Address(RVA = "0x7A6B20", Offset = "0x7A5F20", Length = "0x6D")]
	[Token(Token = "0x60012F0")]
	public void GetComponents(List<T> results) { }

	[Address(RVA = "0x3058B80", Offset = "0x3057F80", Length = "0x95")]
	[Token(Token = "0x60012EF")]
	public void GetComponents(Type type, List<Component> results) { }

	[Address(RVA = "0x3058B80", Offset = "0x3057F80", Length = "0x95")]
	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x60012EE")]
	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	[Address(RVA = "0x3058B20", Offset = "0x3057F20", Length = "0x52")]
	[Token(Token = "0x60012FA")]
	private static void GetComponentsForListInternal_Injected(IntPtr _unity_self, Type searchType, object resultList) { }

	[Address(RVA = "0x7A6960", Offset = "0x7A5D60", Length = "0x76")]
	[Token(Token = "0x60012E7")]
	public void GetComponentsInChildren(List<T> results) { }

	[Address(RVA = "0x7A6820", Offset = "0x7A5C20", Length = "0x64")]
	[Token(Token = "0x60012E6")]
	public T[] GetComponentsInChildren() { }

	[Address(RVA = "0x7A6890", Offset = "0x7A5C90", Length = "0x6E")]
	[Token(Token = "0x60012E5")]
	public void GetComponentsInChildren(bool includeInactive, List<T> result) { }

	[Address(RVA = "0x7A6900", Offset = "0x7A5D00", Length = "0x5D")]
	[Token(Token = "0x60012E4")]
	public T[] GetComponentsInChildren(bool includeInactive) { }

	[Address(RVA = "0x7A69E0", Offset = "0x7A5DE0", Length = "0x64")]
	[Token(Token = "0x60012ED")]
	public T[] GetComponentsInParent() { }

	[Address(RVA = "0x7A6A50", Offset = "0x7A5E50", Length = "0x6E")]
	[Token(Token = "0x60012EC")]
	public void GetComponentsInParent(bool includeInactive, List<T> results) { }

	[Address(RVA = "0x7A6AC0", Offset = "0x7A5EC0", Length = "0x5D")]
	[Token(Token = "0x60012EB")]
	public T[] GetComponentsInParent(bool includeInactive) { }

	[Address(RVA = "0x3058C90", Offset = "0x3058090", Length = "0x1DB")]
	[FreeFunction("SendMessage", HasExplicitThis = True)]
	[Token(Token = "0x60012F4")]
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	[Address(RVA = "0x3058C20", Offset = "0x3058020", Length = "0x62")]
	[Token(Token = "0x60012FB")]
	private static void SendMessage_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, object value, SendMessageOptions options) { }

	[Address(RVA = "0x3059220", Offset = "0x3058620", Length = "0xAF")]
	[Token(Token = "0x60012F1")]
	public void set_tag(string value) { }

	[Address(RVA = "0x3058E70", Offset = "0x3058270", Length = "0x1EA")]
	[Token(Token = "0x60012DF")]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public bool TryGetComponent(Type type, out Component component) { }

	[Address(RVA = "0x7A6CB0", Offset = "0x7A60B0", Length = "0x5D")]
	[Token(Token = "0x60012E0")]
	public bool TryGetComponent(out T component) { }

}

