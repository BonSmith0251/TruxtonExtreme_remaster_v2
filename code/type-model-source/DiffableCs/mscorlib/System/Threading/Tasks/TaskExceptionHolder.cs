namespace System.Threading.Tasks;

[Token(Token = "0x2000282")]
internal class TaskExceptionHolder
{
	[Token(Token = "0x4000B32")]
	private static readonly bool s_failFastOnUnobservedException; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B33")]
	private readonly Task m_task; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B34")]
	private LowLevelListWithIList<ExceptionDispatchInfo> m_faultExceptions; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B35")]
	private ExceptionDispatchInfo m_cancellationException; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B36")]
	private bool m_isHandled; //Field offset: 0x28

	[Token(Token = "0x170001F8")]
	internal bool ContainsFaultList
	{
		[Address(RVA = "0x20B6550", Offset = "0x20B5950", Length = "0x1B")]
		[Token(Token = "0x60014E6")]
		internal get { } //Length: 27
	}

	[Address(RVA = "0x20B6510", Offset = "0x20B5910", Length = "0x36")]
	[Token(Token = "0x60014EF")]
	private static TaskExceptionHolder() { }

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60014E3")]
	internal TaskExceptionHolder(Task task) { }

	[Address(RVA = "0x20B5D50", Offset = "0x20B5150", Length = "0x10B")]
	[Token(Token = "0x60014E7")]
	internal void Add(object exceptionObject, bool representsCancellation) { }

	[Address(RVA = "0x20B5910", Offset = "0x20B4D10", Length = "0x431")]
	[Token(Token = "0x60014E9")]
	private void AddFaultException(object exceptionObject) { }

	[Address(RVA = "0x20B5E60", Offset = "0x20B5260", Length = "0x1EB")]
	[Token(Token = "0x60014EC")]
	internal AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException) { }

	[Address(RVA = "0x20B6050", Offset = "0x20B5450", Length = "0x1F3")]
	[Token(Token = "0x60014E5")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x20B6550", Offset = "0x20B5950", Length = "0x1B")]
	[Token(Token = "0x60014E6")]
	internal bool get_ContainsFaultList() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60014EE")]
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	[Address(RVA = "0x20B6250", Offset = "0x20B5650", Length = "0xC8")]
	[Token(Token = "0x60014ED")]
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	[Address(RVA = "0x20B6320", Offset = "0x20B5720", Length = "0x7B")]
	[Token(Token = "0x60014EB")]
	internal void MarkAsHandled(bool calledFromFinalizer) { }

	[Address(RVA = "0x20B63A0", Offset = "0x20B57A0", Length = "0x69")]
	[Token(Token = "0x60014EA")]
	private void MarkAsUnhandled() { }

	[Address(RVA = "0x20B6410", Offset = "0x20B5810", Length = "0xF4")]
	[Token(Token = "0x60014E8")]
	private void SetCancellationException(object exceptionObject) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60014E4")]
	private static bool ShouldFailFastOnUnobservedException() { }

}

