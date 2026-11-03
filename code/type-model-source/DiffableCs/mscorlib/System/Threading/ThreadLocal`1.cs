namespace System.Threading;

[DebuggerDisplay("IsValueCreated={IsValueCreated}, Value={ValueForDebugDisplay}, Count={ValuesCountForDebugDisplay}")]
[DebuggerTypeProxy(typeof(SystemThreading_ThreadLocalDebugView`1))]
[Token(Token = "0x200021B")]
public class ThreadLocal : IDisposable
{
	[Token(Token = "0x200021F")]
	private class FinalizationHelper
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009F4")]
		internal LinkedSlotVolatile<T>[] SlotArray; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009F5")]
		private bool m_trackAllValues; //Field offset: 0x0

		[Address(RVA = "0x1BC27C0", Offset = "0x1BC1BC0", Length = "0x44")]
		[Token(Token = "0x6001246")]
		internal FinalizationHelper(LinkedSlotVolatile<T>[] slotArray, bool trackAllValues) { }

		[Address(RVA = "0x1BC2190", Offset = "0x1BC1590", Length = "0x2A2")]
		[Token(Token = "0x6001247")]
		protected virtual void Finalize() { }

	}

	[Token(Token = "0x200021E")]
	private class IdManager
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009F2")]
		private int m_nextIdToTry; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009F3")]
		private List<Boolean> m_freeIds; //Field offset: 0x0

		[Address(RVA = "0x1C73AF0", Offset = "0x1C72EF0", Length = "0x77")]
		[Token(Token = "0x6001245")]
		public IdManager() { }

		[Address(RVA = "0x1C73710", Offset = "0x1C72B10", Length = "0x19C")]
		[Token(Token = "0x6001243")]
		internal int GetId() { }

		[Address(RVA = "0x1C738B0", Offset = "0x1C72CB0", Length = "0xD2")]
		[Token(Token = "0x6001244")]
		internal void ReturnId(int id) { }

	}

	[Token(Token = "0x200021D")]
	private sealed class LinkedSlot
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009EE")]
		internal LinkedSlot<T> Next; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009EF")]
		internal LinkedSlot<T> Previous; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009F0")]
		internal LinkedSlotVolatile<T>[] SlotArray; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009F1")]
		internal T Value; //Field offset: 0x0

		[Address(RVA = "0xB0A110", Offset = "0xB09510", Length = "0x36")]
		[Token(Token = "0x6001242")]
		internal LinkedSlot(LinkedSlotVolatile<T>[] slotArray) { }

	}

	[Token(Token = "0x200021C")]
	private struct LinkedSlotVolatile
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009ED")]
		internal LinkedSlot<T> Value; //Field offset: 0x0

	}

	[ThreadStatic]
	[Token(Token = "0x40009E6")]
	private static LinkedSlotVolatile<T>[] ts_slotArray; //Field offset: 0xFFFFFFFF
	[ThreadStatic]
	[Token(Token = "0x40009E7")]
	private static FinalizationHelper<T> ts_finalizationHelper; //Field offset: 0xFFFFFFFF
	[Token(Token = "0x40009EA")]
	private static IdManager<T> s_idManager; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009E5")]
	private Func<T> m_valueFactory; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009E8")]
	private int m_idComplement; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009E9")]
	private bool m_initialized; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009EB")]
	private LinkedSlot<T> m_linkedSlot; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009EC")]
	private bool m_trackAllValues; //Field offset: 0x0

	[Token(Token = "0x170001A5")]
	public bool IsValueCreated
	{
		[Address(RVA = "0x10843B0", Offset = "0x10837B0", Length = "0x105")]
		[Token(Token = "0x600123E")]
		 get { } //Length: 261
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x170001A4")]
	public T Value
	{
		[Address(RVA = "0x10844C0", Offset = "0x10838C0", Length = "0xF0")]
		[Token(Token = "0x6001239")]
		 get { } //Length: 240
		[Address(RVA = "0x1084920", Offset = "0x1083D20", Length = "0x102")]
		[Token(Token = "0x600123A")]
		 set { } //Length: 258
	}

	[Address(RVA = "0x10840D0", Offset = "0x10834D0", Length = "0xF9")]
	[Token(Token = "0x6001241")]
	private static ThreadLocal`1() { }

	[Address(RVA = "0x10842C0", Offset = "0x10836C0", Length = "0xEC")]
	[Token(Token = "0x6001233")]
	public ThreadLocal`1(Func<T> valueFactory) { }

	[Address(RVA = "0x1081D10", Offset = "0x1081110", Length = "0x2B4")]
	[Token(Token = "0x600123D")]
	private void CreateLinkedSlot(LinkedSlotVolatile<T>[] slotArray, int id, T value) { }

	[Address(RVA = "0x10823B0", Offset = "0x10817B0", Length = "0x61")]
	[Token(Token = "0x6001236")]
	public override void Dispose() { }

	[Address(RVA = "0x1082420", Offset = "0x1081820", Length = "0x2D6")]
	[Token(Token = "0x6001237")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1082700", Offset = "0x1081B00", Length = "0x7A")]
	[Token(Token = "0x6001235")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x10843B0", Offset = "0x10837B0", Length = "0x105")]
	[Token(Token = "0x600123E")]
	public bool get_IsValueCreated() { }

	[Address(RVA = "0x10844C0", Offset = "0x10838C0", Length = "0xF0")]
	[Token(Token = "0x6001239")]
	public T get_Value() { }

	[Address(RVA = "0x1082780", Offset = "0x1081B80", Length = "0x40")]
	[Token(Token = "0x6001240")]
	private static int GetNewTableSize(int minSize) { }

	[Address(RVA = "0x1082A50", Offset = "0x1081E50", Length = "0x303")]
	[Token(Token = "0x600123B")]
	private T GetValueSlow() { }

	[Address(RVA = "0x1082FF0", Offset = "0x10823F0", Length = "0x26A")]
	[Token(Token = "0x600123F")]
	private void GrowTable(ref LinkedSlotVolatile<T>[] table, int minLength) { }

	[Address(RVA = "0x10832E0", Offset = "0x10826E0", Length = "0x75")]
	[Token(Token = "0x6001234")]
	private void Initialize(Func<T> valueFactory, bool trackAllValues) { }

	[Address(RVA = "0x1084920", Offset = "0x1083D20", Length = "0x102")]
	[Token(Token = "0x600123A")]
	public void set_Value(T value) { }

	[Address(RVA = "0x1083360", Offset = "0x1082760", Length = "0x46E")]
	[Token(Token = "0x600123C")]
	private void SetValueSlow(T value, LinkedSlotVolatile<T>[] slotArray) { }

	[Address(RVA = "0x1083D10", Offset = "0x1083110", Length = "0x110")]
	[Token(Token = "0x6001238")]
	public virtual string ToString() { }

}

