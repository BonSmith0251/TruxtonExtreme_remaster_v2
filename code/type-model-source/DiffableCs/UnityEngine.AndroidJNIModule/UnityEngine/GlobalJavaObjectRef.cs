namespace UnityEngine;

[Token(Token = "0x2000004")]
internal class GlobalJavaObjectRef
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000002")]
	private bool m_disposed; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000003")]
	protected IntPtr m_jobject; //Field offset: 0x18

	[Address(RVA = "0x2FA6520", Offset = "0x2FA5920", Length = "0x62")]
	[Token(Token = "0x6000005")]
	public GlobalJavaObjectRef(IntPtr jobject) { }

	[Address(RVA = "0x2FA6440", Offset = "0x2FA5840", Length = "0x4C")]
	[Token(Token = "0x6000008")]
	public void Dispose() { }

	[Address(RVA = "0x2FA6490", Offset = "0x2FA5890", Length = "0x8A")]
	[Token(Token = "0x6000006")]
	protected virtual void Finalize() { }

	[Address(RVA = "0xF48BF0", Offset = "0xF47FF0", Length = "0x17")]
	[Token(Token = "0x6000007")]
	public static IntPtr op_Implicit(GlobalJavaObjectRef obj) { }

}

