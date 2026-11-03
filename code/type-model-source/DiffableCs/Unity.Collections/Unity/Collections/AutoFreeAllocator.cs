namespace Unity.Collections;

[BurstCompile]
[Token(Token = "0x2000034")]
internal struct AutoFreeAllocator : IAllocator, IDisposable
{
	[Token(Token = "0x2000036")]
	public static class Try_000000E3$BurstDirectCall
	{
		[Token(Token = "0x4000081")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x28C5FC0", Offset = "0x28C53C0", Length = "0x168")]
		[Token(Token = "0x60000FF")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x28C5E40", Offset = "0x28C5240", Length = "0x175")]
		[BurstDiscard]
		[Token(Token = "0x60000FE")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x28A9630", Offset = "0x28A8A30", Length = "0x1E8")]
		[Token(Token = "0x6000100")]
		public static int Invoke(IntPtr state, ref Block block) { }

	}

	[Token(Token = "0x2000035")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class Try_000000E3$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x17A31D0", Offset = "0x17A25D0", Length = "0xA6")]
		[Token(Token = "0x60000FA")]
		public Try_000000E3$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x28C6130", Offset = "0x28C5530", Length = "0x97")]
		[Token(Token = "0x60000FC")]
		public override IAsyncResult BeginInvoke(IntPtr state, ref Block block, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

		[Address(RVA = "0xF64600", Offset = "0xF63A00", Length = "0x27")]
		[Token(Token = "0x60000FD")]
		public override int EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x60000FB")]
		public override int Invoke(IntPtr state, ref Block block) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007D")]
	private ArrayOfArrays<IntPtr> m_allocated; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400007E")]
	private ArrayOfArrays<IntPtr> m_tofree; //Field offset: 0x20
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400007F")]
	private AllocatorHandle m_handle; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000080")]
	private AllocatorHandle m_backingAllocatorHandle; //Field offset: 0x44

	[Token(Token = "0x17000025")]
	public override TryFunction Function
	{
		[Address(RVA = "0x28A9A20", Offset = "0x28A8E20", Length = "0xD5")]
		[Token(Token = "0x60000F1")]
		 get { } //Length: 213
	}

	[Token(Token = "0x17000026")]
	public override AllocatorHandle Handle
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[Token(Token = "0x60000F4")]
		 get { } //Length: 4
		[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
		[Token(Token = "0x60000F5")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000029")]
	public override bool IsAutoDispose
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60000F8")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000028")]
	public override bool IsCustomAllocator
	{
		[Address(RVA = "0x28A9B00", Offset = "0x28A8F00", Length = "0x9")]
		[Token(Token = "0x60000F7")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000027")]
	public override Allocator ToAllocator
	{
		[Address(RVA = "0x28A9B10", Offset = "0x28A8F10", Length = "0xE")]
		[Token(Token = "0x60000F6")]
		 get { } //Length: 14
	}

	[Address(RVA = "0x28A9430", Offset = "0x28A8830", Length = "0x53")]
	[Token(Token = "0x60000F0")]
	public override void Dispose() { }

	[Address(RVA = "0x28A9490", Offset = "0x28A8890", Length = "0x9B")]
	[Token(Token = "0x60000EF")]
	public void FreeAll() { }

	[Address(RVA = "0x28A9A20", Offset = "0x28A8E20", Length = "0xD5")]
	[Token(Token = "0x60000F1")]
	public override TryFunction get_Function() { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[Token(Token = "0x60000F4")]
	public override AllocatorHandle get_Handle() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60000F8")]
	public override bool get_IsAutoDispose() { }

	[Address(RVA = "0x28A9B00", Offset = "0x28A8F00", Length = "0x9")]
	[Token(Token = "0x60000F7")]
	public override bool get_IsCustomAllocator() { }

	[Address(RVA = "0x28A9B10", Offset = "0x28A8F10", Length = "0xE")]
	[Token(Token = "0x60000F6")]
	public override Allocator get_ToAllocator() { }

	[Address(RVA = "0x28A9530", Offset = "0x28A8930", Length = "0xC1")]
	[Token(Token = "0x60000EE")]
	public void Initialize(AllocatorHandle backingAllocatorHandle) { }

	[Address(RVA = "0x1116990", Offset = "0x1115D90", Length = "0x4")]
	[Token(Token = "0x60000F5")]
	public override void set_Handle(AllocatorHandle value) { }

	[Address(RVA = "0x28A9820", Offset = "0x28A8C20", Length = "0xD4")]
	[Token(Token = "0x60000F2")]
	public override int Try(ref Block block) { }

	[Address(RVA = "0x28A9630", Offset = "0x28A8A30", Length = "0x1E8")]
	[BurstCompile]
	[MonoPInvokeCallback(typeof(TryFunction))]
	[Token(Token = "0x60000F3")]
	internal static int Try(IntPtr state, ref Block block) { }

	[Address(RVA = "0x28A9600", Offset = "0x28A8A00", Length = "0x23")]
	[BurstCompile]
	[MonoPInvokeCallback(typeof(TryFunction))]
	[Token(Token = "0x60000F9")]
	internal static int Try$BurstManaged(IntPtr state, ref Block block) { }

	[Address(RVA = "0x28A9900", Offset = "0x28A8D00", Length = "0x11D")]
	[Token(Token = "0x60000ED")]
	public void Update() { }

}

