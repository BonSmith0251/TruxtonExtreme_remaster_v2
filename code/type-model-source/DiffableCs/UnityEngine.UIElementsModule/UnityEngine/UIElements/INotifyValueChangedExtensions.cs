namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x20000E8")]
public static class INotifyValueChangedExtensions
{

	[Address(RVA = "0x82F790", Offset = "0x82EB90", Length = "0xA4")]
	[Extension]
	[Token(Token = "0x6000703")]
	public static bool RegisterValueChangedCallback(INotifyValueChanged<T> control, EventCallback<ChangeEvent`1<T>> callback) { }

	[Address(RVA = "0x82F8F0", Offset = "0x82ECF0", Length = "0xA4")]
	[Extension]
	[Token(Token = "0x6000704")]
	public static bool UnregisterValueChangedCallback(INotifyValueChanged<T> control, EventCallback<ChangeEvent`1<T>> callback) { }

}

