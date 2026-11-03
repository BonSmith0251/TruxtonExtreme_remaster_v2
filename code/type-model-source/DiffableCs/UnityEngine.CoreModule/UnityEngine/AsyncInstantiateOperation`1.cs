namespace UnityEngine;

[Token(Token = "0x200017F")]
public class AsyncInstantiateOperation : AsyncInstantiateOperation
{
	[ExcludeFromDocs]
	[Token(Token = "0x2000180")]
	internal struct Awaiter : INotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400061D")]
		private readonly Awaitable _awaitable; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400061E")]
		private readonly AsyncInstantiateOperation<T> _op; //Field offset: 0x0

		[Token(Token = "0x170002C5")]
		public bool IsCompleted
		{
			[Address(RVA = "0x1650670", Offset = "0x164FA70", Length = "0x1C")]
			[Token(Token = "0x6001262")]
			 get { } //Length: 28
		}

		[Address(RVA = "0x1650390", Offset = "0x164F790", Length = "0x102")]
		[Token(Token = "0x6001260")]
		public Awaiter(AsyncInstantiateOperation<T> op) { }

		[Address(RVA = "0x1650670", Offset = "0x164FA70", Length = "0x1C")]
		[Token(Token = "0x6001262")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x16489E0", Offset = "0x1647DE0", Length = "0x6E")]
		[Token(Token = "0x6001263")]
		public T[] GetResult() { }

		[Address(RVA = "0x1649AD0", Offset = "0x1648ED0", Length = "0x1D")]
		[Token(Token = "0x6001261")]
		public override void OnCompleted(Action continuation) { }

	}


	[Token(Token = "0x170002C4")]
	public T[] Result
	{
		[Address(RVA = "0x100B660", Offset = "0x100AA60", Length = "0x5D")]
		[Token(Token = "0x600125D")]
		 get { } //Length: 93
	}

	[Address(RVA = "0x100B5F0", Offset = "0x100A9F0", Length = "0x69")]
	[Token(Token = "0x600125C")]
	internal AsyncInstantiateOperation`1(IntPtr ptr, CancellationToken cancellationToken) { }

	[Address(RVA = "0x100B340", Offset = "0x100A740", Length = "0xD1")]
	[Token(Token = "0x600125E")]
	internal virtual Object[] CreateResultArray(int size) { }

	[Address(RVA = "0x100B660", Offset = "0x100AA60", Length = "0x5D")]
	[Token(Token = "0x600125D")]
	public T[] get_Result() { }

	[Address(RVA = "0x100B540", Offset = "0x100A940", Length = "0x3E")]
	[ExcludeFromDocs]
	[Token(Token = "0x600125F")]
	public Awaiter<T> GetAwaiter() { }

}

