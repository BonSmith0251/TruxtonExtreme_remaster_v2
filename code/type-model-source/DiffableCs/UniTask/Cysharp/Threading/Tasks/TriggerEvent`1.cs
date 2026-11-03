namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000073")]
public struct TriggerEvent
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000F9")]
	private ITriggerHandler<T> head; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000FA")]
	private ITriggerHandler<T> iteratingHead; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000FB")]
	private bool preserveRemoveSelf; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000FC")]
	private ITriggerHandler<T> iteratingNode; //Field offset: 0x0

	[Address(RVA = "0x109CDA0", Offset = "0x109C1A0", Length = "0x3D2")]
	[Token(Token = "0x600018F")]
	public void Add(ITriggerHandler<T> handler) { }

	[Address(RVA = "0x109D310", Offset = "0x109C710", Length = "0x49")]
	[Token(Token = "0x600018A")]
	private void LogError(Exception ex) { }

	[Address(RVA = "0x109D450", Offset = "0x109C850", Length = "0x49D")]
	[Token(Token = "0x6000190")]
	public void Remove(ITriggerHandler<T> handler) { }

	[Address(RVA = "0x109E4A0", Offset = "0x109D8A0", Length = "0x23F")]
	[Token(Token = "0x600018C")]
	public void SetCanceled(CancellationToken cancellationToken) { }

	[Address(RVA = "0x109F940", Offset = "0x109ED40", Length = "0x235")]
	[Token(Token = "0x600018D")]
	public void SetCompleted() { }

	[Address(RVA = "0x10A0480", Offset = "0x109F880", Length = "0x23F")]
	[Token(Token = "0x600018E")]
	public void SetError(Exception exception) { }

	[Address(RVA = "0x10A19C0", Offset = "0x10A0DC0", Length = "0x2E8")]
	[Token(Token = "0x600018B")]
	public void SetResult(T value) { }

}

