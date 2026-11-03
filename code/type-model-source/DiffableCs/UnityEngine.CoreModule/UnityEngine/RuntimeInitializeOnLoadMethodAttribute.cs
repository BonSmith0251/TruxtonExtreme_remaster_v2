namespace UnityEngine;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = False)]
[RequiredByNativeCode]
[Token(Token = "0x20001BB")]
public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400068C")]
	private RuntimeInitializeLoadType m_LoadType; //Field offset: 0x10

	[Token(Token = "0x170002F5")]
	private RuntimeInitializeLoadType loadType
	{
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x60013F8")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x30711F0", Offset = "0x30705F0", Length = "0x1D")]
	[Token(Token = "0x60013F6")]
	public RuntimeInitializeOnLoadMethodAttribute() { }

	[Address(RVA = "0x3071210", Offset = "0x3070610", Length = "0x24")]
	[Token(Token = "0x60013F7")]
	public RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x60013F8")]
	private void set_loadType(RuntimeInitializeLoadType value) { }

}

