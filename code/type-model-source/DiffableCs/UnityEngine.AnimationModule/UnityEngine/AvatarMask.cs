namespace UnityEngine;

[MovedFrom(True, "UnityEditor.Animations", "UnityEditor", null)]
[NativeHeader("Modules/Animation/AvatarMask.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
[Token(Token = "0x2000024")]
[UsedByNativeCode]
public sealed class AvatarMask : object
{

	[Token(Token = "0x1700004F")]
	public int transformCount
	{
		[Address(RVA = "0x2FC1A30", Offset = "0x2FC0E30", Length = "0x76")]
		[Token(Token = "0x6000213")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x2FC1980", Offset = "0x2FC0D80", Length = "0x6E")]
	[Token(Token = "0x6000210")]
	public AvatarMask() { }

	[Address(RVA = "0x2FC1A30", Offset = "0x2FC0E30", Length = "0x76")]
	[Token(Token = "0x6000213")]
	public int get_transformCount() { }

	[Address(RVA = "0x2FC19F0", Offset = "0x2FC0DF0", Length = "0x33")]
	[Token(Token = "0x6000218")]
	private static int get_transformCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FC15E0", Offset = "0x2FC09E0", Length = "0x83")]
	[NativeMethod("GetBodyPart")]
	[Token(Token = "0x6000212")]
	public bool GetHumanoidBodyPartActive(AvatarMaskBodyPart index) { }

	[Address(RVA = "0x2FC15A0", Offset = "0x2FC09A0", Length = "0x40")]
	[Token(Token = "0x6000217")]
	private static bool GetHumanoidBodyPartActive_Injected(IntPtr _unity_self, AvatarMaskBodyPart index) { }

	[Address(RVA = "0x2FC1670", Offset = "0x2FC0A70", Length = "0x8D")]
	[Token(Token = "0x6000216")]
	public bool GetTransformActive(int index) { }

	[Address(RVA = "0x2FC1750", Offset = "0x2FC0B50", Length = "0x113")]
	[Token(Token = "0x6000214")]
	public string GetTransformPath(int index) { }

	[Address(RVA = "0x2FC1700", Offset = "0x2FC0B00", Length = "0x50")]
	[Token(Token = "0x6000219")]
	private static void GetTransformPath_Injected(IntPtr _unity_self, int index, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x2FC18B0", Offset = "0x2FC0CB0", Length = "0x83")]
	[Token(Token = "0x6000215")]
	private float GetTransformWeight(int index) { }

	[Address(RVA = "0x2FC1870", Offset = "0x2FC0C70", Length = "0x40")]
	[Token(Token = "0x600021A")]
	private static float GetTransformWeight_Injected(IntPtr _unity_self, int index) { }

	[Address(RVA = "0x2FC1940", Offset = "0x2FC0D40", Length = "0x33")]
	[FreeFunction("AnimationBindings::CreateAvatarMask")]
	[Token(Token = "0x6000211")]
	private static void Internal_Create(AvatarMask self) { }

}

