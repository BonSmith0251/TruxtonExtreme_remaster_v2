namespace UnityEngine.XR.WindowsMR.Input;

[InputControlLayout(displayName = "Windows MR Headset", hideInUI = True)]
[Token(Token = "0x2000014")]
public class WMRHMD : XRHMD
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x400006E")]
	private ButtonControl <userPresence>k__BackingField; //Field offset: 0x1E0

	[InputControl]
	[InputControl(name = "devicePosition", layout = "Vector3", aliases = new IL2CPP_TYPE_STRING[] {"HeadPosition"})]
	[InputControl(name = "deviceRotation", layout = "Quaternion", aliases = new IL2CPP_TYPE_STRING[] {"HeadRotation"})]
	[Token(Token = "0x17000069")]
	public ButtonControl userPresence
	{
		[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60000F0")]
		 get { } //Length: 8
		[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60000F1")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28D98E0", Offset = "0x28D8CE0", Length = "0x7")]
	[Token(Token = "0x60000F3")]
	public WMRHMD() { }

	[Address(RVA = "0x28F2800", Offset = "0x28F1C00", Length = "0x6C")]
	[Token(Token = "0x60000F2")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60000F0")]
	public ButtonControl get_userPresence() { }

	[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x60000F1")]
	protected void set_userPresence(ButtonControl value) { }

}

