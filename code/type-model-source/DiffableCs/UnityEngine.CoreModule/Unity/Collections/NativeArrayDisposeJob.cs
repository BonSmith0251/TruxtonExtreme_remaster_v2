namespace Unity.Collections;

[NativeClass(null)]
[Token(Token = "0x200005D")]
internal struct NativeArrayDisposeJob : IJob
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400010A")]
	internal NativeArrayDispose Data; //Field offset: 0x0

	[Address(RVA = "0x2FE3BC0", Offset = "0x2FE2FC0", Length = "0x41")]
	[Token(Token = "0x6000124")]
	public override void Execute() { }

	[Address(RVA = "0x2FE3C10", Offset = "0x2FE3010", Length = "0x30")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000125")]
	internal static void RegisterNativeArrayDisposeJobReflectionData() { }

}

