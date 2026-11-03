namespace System.Runtime.CompilerServices;

[IsReadOnly]
[Token(Token = "0x2000497")]
public struct ConfiguredTaskAwaitable
{
	[IsReadOnly]
	[Token(Token = "0x2000498")]
	internal struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001267")]
		internal readonly Task m_task; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001268")]
		internal readonly bool m_continueOnCapturedContext; //Field offset: 0x8

		[Token(Token = "0x1700040B")]
		public bool IsCompleted
		{
			[Address(RVA = "0xFE3740", Offset = "0xFE2B40", Length = "0x1C")]
			[Token(Token = "0x600211D")]
			 get { } //Length: 28
		}

		[Address(RVA = "0xAEE570", Offset = "0xAED970", Length = "0x28")]
		[Token(Token = "0x600211C")]
		internal ConfiguredTaskAwaiter(Task task, bool continueOnCapturedContext) { }

		[Address(RVA = "0xFE3740", Offset = "0xFE2B40", Length = "0x1C")]
		[Token(Token = "0x600211D")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x1F33130", Offset = "0x1F32530", Length = "0x48")]
		[StackTraceHidden]
		[Token(Token = "0x6002120")]
		public void GetResult() { }

		[Address(RVA = "0x1F33180", Offset = "0x1F32580", Length = "0xB8")]
		[Token(Token = "0x600211E")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x1F33240", Offset = "0x1F32640", Length = "0xB8")]
		[Token(Token = "0x600211F")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001266")]
	private readonly ConfiguredTaskAwaiter m_configuredTaskAwaiter; //Field offset: 0x0

	[Address(RVA = "0x1F330E0", Offset = "0x1F324E0", Length = "0x4A")]
	[Token(Token = "0x600211A")]
	internal ConfiguredTaskAwaitable(Task task, bool continueOnCapturedContext) { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x600211B")]
	public ConfiguredTaskAwaiter GetAwaiter() { }

}

