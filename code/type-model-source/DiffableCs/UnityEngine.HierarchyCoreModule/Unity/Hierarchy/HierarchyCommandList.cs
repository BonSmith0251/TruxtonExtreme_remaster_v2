namespace Unity.Hierarchy;

[NativeHeader("Modules/HierarchyCore/Public/HierarchyCommandList.h")]
[NativeHeader("Modules/HierarchyCore/HierarchyCommandListBindings.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000019")]
public sealed class HierarchyCommandList : IDisposable
{
	[Token(Token = "0x200001A")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x600008E")]
		public static IntPtr ConvertToUnmanaged(HierarchyCommandList cmdList) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000034")]
	private IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000035")]
	private readonly bool m_IsOwner; //Field offset: 0x18

	[Address(RVA = "0x3048C80", Offset = "0x3048080", Length = "0x2A")]
	[Token(Token = "0x6000087")]
	private HierarchyCommandList(IntPtr nativePtr) { }

	[Address(RVA = "0x30D5520", Offset = "0x30D4920", Length = "0x68")]
	[RequiredByNativeCode]
	[Token(Token = "0x600008D")]
	private static IntPtr CreateCommandList(IntPtr nativePtr) { }

	[Address(RVA = "0x30D5590", Offset = "0x30D4990", Length = "0x33")]
	[FreeFunction("HierarchyCommandListBindings::Destroy", IsThreadSafe = True)]
	[Token(Token = "0x600008C")]
	private static void Destroy(IntPtr nativePtr) { }

	[Address(RVA = "0x30D5630", Offset = "0x30D4A30", Length = "0x90")]
	[Token(Token = "0x6000089")]
	public override void Dispose() { }

	[Address(RVA = "0x30D55D0", Offset = "0x30D49D0", Length = "0x56")]
	[Token(Token = "0x600008A")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x30D56C0", Offset = "0x30D4AC0", Length = "0x9B")]
	[Token(Token = "0x6000088")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x30D5760", Offset = "0x30D4B60", Length = "0xC6")]
	[Token(Token = "0x600008B")]
	internal static HierarchyCommandList FromIntPtr(IntPtr handlePtr) { }

}

