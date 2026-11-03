namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIState.h")]
[Token(Token = "0x2000027")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal class ObjectGUIState : IDisposable
{
	[Token(Token = "0x2000028")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x60001F6")]
		public static IntPtr ConvertToNative(ObjectGUIState objectGUIState) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000FE")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Address(RVA = "0x30F6EA0", Offset = "0x30F62A0", Length = "0x3B")]
	[Token(Token = "0x60001F0")]
	public ObjectGUIState() { }

	[Address(RVA = "0x30F6CB0", Offset = "0x30F60B0", Length = "0x50")]
	[Token(Token = "0x60001F3")]
	private void Destroy() { }

	[Address(RVA = "0x30F6D00", Offset = "0x30F6100", Length = "0x8A")]
	[Token(Token = "0x60001F1")]
	public override void Dispose() { }

	[Address(RVA = "0x30F6D90", Offset = "0x30F6190", Length = "0x95")]
	[Token(Token = "0x60001F2")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x30F6E30", Offset = "0x30F6230", Length = "0x2A")]
	[Token(Token = "0x60001F4")]
	private static IntPtr Internal_Create() { }

	[Address(RVA = "0x30F6E60", Offset = "0x30F6260", Length = "0x33")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x60001F5")]
	private static void Internal_Destroy(IntPtr ptr) { }

}

