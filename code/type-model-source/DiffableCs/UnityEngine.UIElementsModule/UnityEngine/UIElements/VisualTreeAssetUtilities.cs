namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x2000530")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class VisualTreeAssetUtilities
{
	[CompilerGenerated]
	[Token(Token = "0x2000531")]
	private sealed class <EnumerateEnclosingNamespaces>d__0 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001125")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001126")]
		private string <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001127")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001128")]
		private string fullTypeName; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001129")]
		public string <>3__fullTypeName; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400112A")]
		private int <startIndex>5__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x400112B")]
		private int <lastDot>5__2; //Field offset: 0x3C

		[Token(Token = "0x17000A0C")]
		private override string System.Collections.Generic.IEnumerator<System.String>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6002685")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000A0D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6002687")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6002682")]
		public <EnumerateEnclosingNamespaces>d__0(int <>1__state) { }

		[Address(RVA = "0x32BA820", Offset = "0x32B9C20", Length = "0xC9")]
		[Token(Token = "0x6002684")]
		private override bool MoveNext() { }

		[Address(RVA = "0x32BA8F0", Offset = "0x32B9CF0", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x6002688")]
		private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6002685")]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[Address(RVA = "0x32BA8F0", Offset = "0x32B9CF0", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x6002689")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6002687")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x32BA990", Offset = "0x32B9D90", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6002686")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6002683")]
		private override void System.IDisposable.Dispose() { }

	}


	[Address(RVA = "0x32CE040", Offset = "0x32CD440", Length = "0x71")]
	[IteratorStateMachine(typeof(<EnumerateEnclosingNamespaces>d__0))]
	[Token(Token = "0x6002680")]
	public static IEnumerable<String> EnumerateEnclosingNamespaces(string fullTypeName) { }

	[Address(RVA = "0x32CE0C0", Offset = "0x32CD4C0", Length = "0x5E1")]
	[Extension]
	[Token(Token = "0x6002681")]
	public static UxmlNamespaceDefinition FindUxmlNamespaceDefinitionForTypeName(VisualTreeAsset vta, UxmlAsset asset, string fullTypeName) { }

}

