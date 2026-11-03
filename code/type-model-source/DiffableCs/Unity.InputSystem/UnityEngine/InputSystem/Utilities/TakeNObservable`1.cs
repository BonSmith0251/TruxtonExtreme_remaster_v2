namespace UnityEngine.InputSystem.Utilities;

[Token(Token = "0x200025C")]
internal class TakeNObservable : IObservable<TValue>
{
	[Token(Token = "0x200025D")]
	private class Take : IObserver<TValue>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CC1")]
		private IObserver<TValue> m_Observer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000CC2")]
		private int m_Remaining; //Field offset: 0x0

		[Address(RVA = "0xFE3290", Offset = "0xFE2690", Length = "0x4F")]
		[Token(Token = "0x60015F3")]
		public Take(TakeNObservable<TValue> observable, IObserver<TValue> observer) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60015F4")]
		public override void OnCompleted() { }

		[Address(RVA = "0xFE3010", Offset = "0xFE2410", Length = "0x49")]
		[Token(Token = "0x60015F5")]
		public override void OnError(Exception error) { }

		[Address(RVA = "0xFE3060", Offset = "0xFE2460", Length = "0x22F")]
		[Token(Token = "0x60015F6")]
		public override void OnNext(TValue evt) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CBF")]
	private IObservable<TValue> m_Source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CC0")]
	private int m_Count; //Field offset: 0x0

	[Address(RVA = "0xF63E90", Offset = "0xF63290", Length = "0x42")]
	[Token(Token = "0x60015F1")]
	public TakeNObservable`1(IObservable<TValue> source, int count) { }

	[Address(RVA = "0xFE2EE0", Offset = "0xFE22E0", Length = "0x129")]
	[Token(Token = "0x60015F2")]
	public override IDisposable Subscribe(IObserver<TValue> observer) { }

}

