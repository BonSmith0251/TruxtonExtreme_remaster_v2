namespace Cysharp.Threading.Tasks.CompilerServices;

[Token(Token = "0x2000240")]
internal static class StateMachineUtility
{
	[CompilerGenerated]
	[Token(Token = "0x2000241")]
	private sealed class <>c
	{
		[Token(Token = "0x400061A")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400061B")]
		public static Func<FieldInfo, Boolean> <>9__0_0; //Field offset: 0x8

		[Address(RVA = "0x278D060", Offset = "0x278C460", Length = "0x67")]
		[Token(Token = "0x6000CDB")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000CDC")]
		public <>c() { }

		[Address(RVA = "0x278CC10", Offset = "0x278C010", Length = "0x61")]
		[Token(Token = "0x6000CDD")]
		internal bool <GetState>b__0_0(FieldInfo x) { }

	}


	[Address(RVA = "0x278B290", Offset = "0x278A690", Length = "0x1AA")]
	[Token(Token = "0x6000CDA")]
	public static int GetState(IAsyncStateMachine stateMachine) { }

}

