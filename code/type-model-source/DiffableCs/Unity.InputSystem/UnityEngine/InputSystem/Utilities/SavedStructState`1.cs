namespace UnityEngine.InputSystem.Utilities;

[Token(Token = "0x2000268")]
internal sealed class SavedStructState : ISavedState
{
	[Token(Token = "0x2000269")]
	internal sealed class TypedRestore : MulticastDelegate
	{

		[Address(RVA = "0x1116850", Offset = "0x1115C50", Length = "0xB4")]
		[Token(Token = "0x600166D")]
		public TypedRestore(object object, IntPtr method) { }

		[Address(RVA = "0x11166B0", Offset = "0x1115AB0", Length = "0x7B")]
		[Token(Token = "0x600166F")]
		public override IAsyncResult BeginInvoke(ref T state, AsyncCallback callback, object object) { }

		[Address(RVA = "0x1116830", Offset = "0x1115C30", Length = "0x1B")]
		[Token(Token = "0x6001670")]
		public override void EndInvoke(ref T state, IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x600166E")]
		public override void Invoke(ref T state) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CE1")]
	private T m_State; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CE2")]
	private TypedRestore<T> m_RestoreAction; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CE3")]
	private Action m_StaticDisposeCurrentState; //Field offset: 0x0

	[Address(RVA = "0xF55130", Offset = "0xF54530", Length = "0x13E")]
	[Token(Token = "0x600166A")]
	internal SavedStructState`1(ref T state, TypedRestore<T> restoreAction, Action staticDisposeCurrentState = null) { }

	[Address(RVA = "0xF54CF0", Offset = "0xF540F0", Length = "0xEF")]
	[Token(Token = "0x600166C")]
	public override void RestoreSavedState() { }

	[Address(RVA = "0xF54ED0", Offset = "0xF542D0", Length = "0xC3")]
	[Token(Token = "0x600166B")]
	public override void StaticDisposeCurrentState() { }

}

