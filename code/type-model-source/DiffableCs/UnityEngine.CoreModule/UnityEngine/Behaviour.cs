namespace UnityEngine;

[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[Token(Token = "0x200019C")]
[UsedByNativeCode]
public class Behaviour : Component
{

	[NativeProperty]
	[RequiredByNativeCode]
	[Token(Token = "0x170002D8")]
	public bool enabled
	{
		[Address(RVA = "0x3058020", Offset = "0x3057420", Length = "0x76")]
		[Token(Token = "0x60012CB")]
		 get { } //Length: 118
		[Address(RVA = "0x30581B0", Offset = "0x30575B0", Length = "0x86")]
		[Token(Token = "0x60012CC")]
		 set { } //Length: 134
	}

	[NativeProperty]
	[Token(Token = "0x170002D9")]
	public bool isActiveAndEnabled
	{
		[Address(RVA = "0x30580E0", Offset = "0x30574E0", Length = "0x76")]
		[NativeMethod("IsAddedToManager")]
		[Token(Token = "0x60012CD")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x3057F90", Offset = "0x3057390", Length = "0x49")]
	[Token(Token = "0x60012CE")]
	public Behaviour() { }

	[Address(RVA = "0x3058020", Offset = "0x3057420", Length = "0x76")]
	[Token(Token = "0x60012CB")]
	public bool get_enabled() { }

	[Address(RVA = "0x3057FE0", Offset = "0x30573E0", Length = "0x33")]
	[Token(Token = "0x60012CF")]
	private static bool get_enabled_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30580E0", Offset = "0x30574E0", Length = "0x76")]
	[NativeMethod("IsAddedToManager")]
	[Token(Token = "0x60012CD")]
	public bool get_isActiveAndEnabled() { }

	[Address(RVA = "0x30580A0", Offset = "0x30574A0", Length = "0x33")]
	[Token(Token = "0x60012D1")]
	private static bool get_isActiveAndEnabled_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x30581B0", Offset = "0x30575B0", Length = "0x86")]
	[Token(Token = "0x60012CC")]
	public void set_enabled(bool value) { }

	[Address(RVA = "0x3058160", Offset = "0x3057560", Length = "0x42")]
	[Token(Token = "0x60012D0")]
	private static void set_enabled_Injected(IntPtr _unity_self, bool value) { }

}

