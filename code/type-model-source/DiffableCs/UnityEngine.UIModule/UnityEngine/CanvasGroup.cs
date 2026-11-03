namespace UnityEngine;

[NativeClass("UI::CanvasGroup")]
[NativeHeader("Modules/UI/CanvasGroup.h")]
[Token(Token = "0x2000003")]
public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter
{

	[NativeProperty("Alpha", False, TargetType::Function (0))]
	[Token(Token = "0x17000001")]
	public float alpha
	{
		[Address(RVA = "0x342BCB0", Offset = "0x342B0B0", Length = "0x76")]
		[Token(Token = "0x6000002")]
		 get { } //Length: 118
		[Address(RVA = "0x342BF40", Offset = "0x342B340", Length = "0x86")]
		[Token(Token = "0x6000003")]
		 set { } //Length: 134
	}

	[NativeProperty("BlocksRaycasts", False, TargetType::Function (0))]
	[Token(Token = "0x17000003")]
	public bool blocksRaycasts
	{
		[Address(RVA = "0x342BBF0", Offset = "0x342AFF0", Length = "0x76")]
		[Token(Token = "0x6000006")]
		 get { } //Length: 118
		[Address(RVA = "0x342C020", Offset = "0x342B420", Length = "0x86")]
		[Token(Token = "0x6000007")]
		 set { } //Length: 134
	}

	[NativeProperty("IgnoreParentGroups", False, TargetType::Function (0))]
	[Token(Token = "0x17000004")]
	public bool ignoreParentGroups
	{
		[Address(RVA = "0x342BDB0", Offset = "0x342B1B0", Length = "0x76")]
		[Token(Token = "0x6000008")]
		 get { } //Length: 118
		[Address(RVA = "0x342C100", Offset = "0x342B500", Length = "0x86")]
		[Token(Token = "0x6000009")]
		 set { } //Length: 134
	}

	[NativeProperty("Interactable", False, TargetType::Function (0))]
	[Token(Token = "0x17000002")]
	public bool interactable
	{
		[Address(RVA = "0x342BE70", Offset = "0x342B270", Length = "0x76")]
		[Token(Token = "0x6000004")]
		 get { } //Length: 118
		[Address(RVA = "0x342C1E0", Offset = "0x342B5E0", Length = "0x86")]
		[Token(Token = "0x6000005")]
		 set { } //Length: 134
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600000B")]
	public CanvasGroup() { }

	[Address(RVA = "0x342BCB0", Offset = "0x342B0B0", Length = "0x76")]
	[Token(Token = "0x6000002")]
	public float get_alpha() { }

	[Address(RVA = "0x342BC70", Offset = "0x342B070", Length = "0x33")]
	[Token(Token = "0x600000C")]
	private static float get_alpha_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342BBF0", Offset = "0x342AFF0", Length = "0x76")]
	[Token(Token = "0x6000006")]
	public bool get_blocksRaycasts() { }

	[Address(RVA = "0x342BD30", Offset = "0x342B130", Length = "0x33")]
	[Token(Token = "0x6000010")]
	private static bool get_blocksRaycasts_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342BDB0", Offset = "0x342B1B0", Length = "0x76")]
	[Token(Token = "0x6000008")]
	public bool get_ignoreParentGroups() { }

	[Address(RVA = "0x342BD70", Offset = "0x342B170", Length = "0x33")]
	[Token(Token = "0x6000012")]
	private static bool get_ignoreParentGroups_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342BE70", Offset = "0x342B270", Length = "0x76")]
	[Token(Token = "0x6000004")]
	public bool get_interactable() { }

	[Address(RVA = "0x342BE30", Offset = "0x342B230", Length = "0x33")]
	[Token(Token = "0x600000E")]
	private static bool get_interactable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x342BBF0", Offset = "0x342AFF0", Length = "0x76")]
	[Token(Token = "0x600000A")]
	public override bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	[Address(RVA = "0x342BF40", Offset = "0x342B340", Length = "0x86")]
	[Token(Token = "0x6000003")]
	public void set_alpha(float value) { }

	[Address(RVA = "0x342BEF0", Offset = "0x342B2F0", Length = "0x43")]
	[Token(Token = "0x600000D")]
	private static void set_alpha_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x342C020", Offset = "0x342B420", Length = "0x86")]
	[Token(Token = "0x6000007")]
	public void set_blocksRaycasts(bool value) { }

	[Address(RVA = "0x342BFD0", Offset = "0x342B3D0", Length = "0x42")]
	[Token(Token = "0x6000011")]
	private static void set_blocksRaycasts_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x342C100", Offset = "0x342B500", Length = "0x86")]
	[Token(Token = "0x6000009")]
	public void set_ignoreParentGroups(bool value) { }

	[Address(RVA = "0x342C0B0", Offset = "0x342B4B0", Length = "0x42")]
	[Token(Token = "0x6000013")]
	private static void set_ignoreParentGroups_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x342C1E0", Offset = "0x342B5E0", Length = "0x86")]
	[Token(Token = "0x6000005")]
	public void set_interactable(bool value) { }

	[Address(RVA = "0x342C190", Offset = "0x342B590", Length = "0x42")]
	[Token(Token = "0x600000F")]
	private static void set_interactable_Injected(IntPtr _unity_self, bool value) { }

}

