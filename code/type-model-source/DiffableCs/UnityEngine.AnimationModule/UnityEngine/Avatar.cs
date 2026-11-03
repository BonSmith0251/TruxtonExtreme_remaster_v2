namespace UnityEngine;

[NativeHeader("Modules/Animation/Avatar.h")]
[Token(Token = "0x200001E")]
[UsedByNativeCode]
public class Avatar : object
{

	[Token(Token = "0x1700004E")]
	public HumanDescription humanDescription
	{
		[Address(RVA = "0x2FC1B00", Offset = "0x2FC0F00", Length = "0x9A")]
		[Token(Token = "0x600020C")]
		 get { } //Length: 154
	}

	[Token(Token = "0x1700004D")]
	public bool isHuman
	{
		[Address(RVA = "0x2FC1BE0", Offset = "0x2FC0FE0", Length = "0x76")]
		[NativeMethod("IsHuman")]
		[Token(Token = "0x600020B")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700004C")]
	public bool isValid
	{
		[Address(RVA = "0x2FC1CA0", Offset = "0x2FC10A0", Length = "0x76")]
		[NativeMethod("IsValid")]
		[Token(Token = "0x600020A")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x2FC1B00", Offset = "0x2FC0F00", Length = "0x9A")]
	[Token(Token = "0x600020C")]
	public HumanDescription get_humanDescription() { }

	[Address(RVA = "0x2FC1AB0", Offset = "0x2FC0EB0", Length = "0x42")]
	[Token(Token = "0x600020F")]
	private static void get_humanDescription_Injected(IntPtr _unity_self, out HumanDescription ret) { }

	[Address(RVA = "0x2FC1BE0", Offset = "0x2FC0FE0", Length = "0x76")]
	[NativeMethod("IsHuman")]
	[Token(Token = "0x600020B")]
	public bool get_isHuman() { }

	[Address(RVA = "0x2FC1BA0", Offset = "0x2FC0FA0", Length = "0x33")]
	[Token(Token = "0x600020E")]
	private static bool get_isHuman_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FC1CA0", Offset = "0x2FC10A0", Length = "0x76")]
	[NativeMethod("IsValid")]
	[Token(Token = "0x600020A")]
	public bool get_isValid() { }

	[Address(RVA = "0x2FC1C60", Offset = "0x2FC1060", Length = "0x33")]
	[Token(Token = "0x600020D")]
	private static bool get_isValid_Injected(IntPtr _unity_self) { }

}

