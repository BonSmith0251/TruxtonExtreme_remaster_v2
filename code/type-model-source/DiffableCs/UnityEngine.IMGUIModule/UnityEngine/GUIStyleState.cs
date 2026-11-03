namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[Token(Token = "0x2000018")]
public sealed class GUIStyleState
{
	[Token(Token = "0x2000019")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x6000119")]
		public static IntPtr ConvertToNative(GUIStyleState guiStyleState) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400009D")]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400009E")]
	private readonly GUIStyle m_SourceStyle; //Field offset: 0x18

	[NativeProperty("textColor", False, TargetType::Field (1))]
	[Token(Token = "0x1700004E")]
	public Color textColor
	{
		[Address(RVA = "0x30EACA0", Offset = "0x30EA0A0", Length = "0x5A")]
		[Token(Token = "0x6000110")]
		 set { } //Length: 90
	}

	[Address(RVA = "0x30EAC10", Offset = "0x30EA010", Length = "0x3B")]
	[Token(Token = "0x6000113")]
	public GUIStyleState() { }

	[Address(RVA = "0x3010260", Offset = "0x300F660", Length = "0x43")]
	[Token(Token = "0x6000114")]
	private GUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	[Address(RVA = "0x30EAA60", Offset = "0x30E9E60", Length = "0x51")]
	[FreeFunction(Name = "GUIStyleState_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	[Token(Token = "0x6000112")]
	private void Cleanup() { }

	[Address(RVA = "0x30EAA20", Offset = "0x30E9E20", Length = "0x33")]
	[Token(Token = "0x6000118")]
	private static void Cleanup_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30EAAC0", Offset = "0x30E9EC0", Length = "0x99")]
	[Token(Token = "0x6000116")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x30EAB60", Offset = "0x30E9F60", Length = "0x71")]
	[Token(Token = "0x6000115")]
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	[Address(RVA = "0x30EABE0", Offset = "0x30E9FE0", Length = "0x2A")]
	[FreeFunction(Name = "GUIStyleState_Bindings::Init", IsThreadSafe = True)]
	[Token(Token = "0x6000111")]
	private static IntPtr Init() { }

	[Address(RVA = "0x30EACA0", Offset = "0x30EA0A0", Length = "0x5A")]
	[Token(Token = "0x6000110")]
	public void set_textColor(Color value) { }

	[Address(RVA = "0x30EAC50", Offset = "0x30EA050", Length = "0x42")]
	[Token(Token = "0x6000117")]
	private static void set_textColor_Injected(IntPtr _unity_self, in Color value) { }

}

