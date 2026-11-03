namespace TXEKernel;

[Token(Token = "0x2000115")]
public class UsersManager : SimpleSingleton<UsersManager>
{
	[CompilerGenerated]
	[Token(Token = "0x2000116")]
	private struct <Initialize>d__0 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400058C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400058D")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400058E")]
		public Action requestPauseCallback; //Field offset: 0x18

		[Address(RVA = "0x2728EA0", Offset = "0x27282A0", Length = "0x99")]
		[Token(Token = "0x60007D8")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60007D9")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Address(RVA = "0x272BCA0", Offset = "0x272B0A0", Length = "0x1B0")]
	[Token(Token = "0x60007D7")]
	public UsersManager() { }

	[Address(RVA = "0x272BAE0", Offset = "0x272AEE0", Length = "0x7")]
	[Token(Token = "0x60007D6")]
	public string GetGamertag() { }

	[Address(RVA = "0x272BAF0", Offset = "0x272AEF0", Length = "0x1AB")]
	[AsyncStateMachine(typeof(<Initialize>d__0))]
	[Token(Token = "0x60007D4")]
	public UniTask Initialize(GameObject _, Action requestPauseCallback) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007D5")]
	public void Terminate() { }

}

